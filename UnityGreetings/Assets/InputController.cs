﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using DigitalRubyShared;

public class InputController{

    Player Player;
    Camera Camera;
    GestureAdapter GestureAdapter;
    StateMachine StateMachine;
    
    public bool InputLocked;

    public List<Gesture> GestureList;
    public ICommand CheckInputCommand;

    public InputController(Camera camera, Player player, GestureAdapter gestureAdapter, StateMachine stateMachine )
    {
        Camera = camera;
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
            
            StateMachine.CurrentGameState = GameState.CloseDoor;
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
