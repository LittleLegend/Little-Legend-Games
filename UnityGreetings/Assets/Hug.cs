using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class Hug : Gesture {


    public Hug(Player Player, StateMachine StateMachine)
    {
        this.StateMachine = StateMachine;
        this.Player = Player;
    }

    public override void greet()
    {
        Player.PlayerGreeting = Greetings.Hug;
        StateMachine.CurrentGameState = GameState.CompareGreetings;
    }

    public override void checkInput()
    {
        if (Input.GetMouseButton(0)
             && Screenpoint.x >= 0.5
             && Screenpoint.y >= 0.5)
        {
            Player.setGreetCommand(this);
        }
    }
    
}
