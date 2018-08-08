using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using DigitalRubyShared;

public class InputController{

    Player Player;
    GestureAdapter GestureAdapter;
    StateMachine StateMachine;
    
    public bool InputLocked;

    public List<Gesture> GestureList;
    public ICommand CheckInputCommand;

    public InputController( Player player, GestureAdapter gestureAdapter, StateMachine stateMachine )
    {
        
        Player = player;
        GestureAdapter = gestureAdapter;
        StateMachine = stateMachine;
    }

    public void CreateGestures()
    {
        GestureAdapter.CreateTab(Tapgesture_StateUpdated);
        GestureAdapter.CreateLongPress(Longpressgesture_StateUpdated);
        GestureAdapter.CreateSwipe(Swipegesture_StateUpdated);
        GestureAdapter.CreateScale(Scalesgesture_StateUpdated);

    }

    public void RemoveGestures()
    {
        GestureAdapter.RemoveTab();

    }

    public void WatchSceneGesture()
    {
        GestureAdapter.RemoveTab();
        GestureAdapter.CreateTab(WatchsceneTabgesture_StateUpdated);

    }

    public void WatchsceneTabgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            StateMachine.Timer.TimerRunning = true;
            StateMachine.StartCoroutine(StateMachine.Timer.StartTimer(3f));
            StateMachine.CurrentGameState = GameState.SaySomething;
            
        }
    }

    public void Scalesgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            Player.PlayerGreeting = Greetings.Hug;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }
    }

    public void Longpressgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            Player.PlayerGreeting = Greetings.Kiss;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }
    }

    public void Tapgesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            Player.PlayerGreeting = Greetings.Bump;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }
    }

    public void Swipegesture_StateUpdated(GestureRecognizer gesture)
    {
        if (gesture.State == GestureRecognizerState.Ended)
        {
            Player.PlayerGreeting = Greetings.Shake;
            StateMachine.CurrentGameState = GameState.CompareGreetings;
        }
    }

   
}
