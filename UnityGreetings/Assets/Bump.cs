using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public class Bump : Gesture
{

    public Bump(Player Player, StateMachine StateMachine)
    {
        this.StateMachine = StateMachine;
        this.Player = Player;
    }

    public override void greet()
    {
        Player.PlayerGreeting = Greetings.Bump;
        StateMachine.CurrentGameState = GameState.CompareGreetings;

    }

    public override void checkInput()
    {
        if (Input.GetMouseButton(0)
             && Screenpoint.x >= 0.5
             && Screenpoint.y <= 0.5)
        {
            Player.setGreetCommand(this);
        }
    }

}
