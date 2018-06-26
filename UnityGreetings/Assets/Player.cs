using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Player{

    public StateMachine StateMachine;
    public ICommand GreetCommand;
    public Greetings PlayerGreeting;

    public Player(StateMachine StateMachine)
    {
        this.StateMachine = StateMachine;
        GreetCommand = new GreetCommand(new None(this,StateMachine));
    }

    public void setGreetCommand(Gesture Gesture)
    {
        GreetCommand = new GreetCommand(Gesture);
        
    }

    public void resetGreetCommand()
    {
        GreetCommand = new GreetCommand(new None(this, StateMachine));
    }
    
    public void greet()
    {

        GreetCommand.execute();
        resetGreetCommand();
    }

    public void miss()
    {
        resetGreetCommand();
        GreetCommand.execute();
    }
    public void openDoor()
    {
        if (StateMachine.CurrentGameState == GameState.ButtonClick)
        {
            StateMachine.CurrentGameState = GameState.OpenDoor;
        }
    }

    public void closeDoor()
    {
        StateMachine.CurrentGameState = GameState.CloseDoor;
    }

}
