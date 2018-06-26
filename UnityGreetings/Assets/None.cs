using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class None : Gesture {

    
    public None(Player Player, StateMachine StateMachine)
    {
        this.StateMachine = StateMachine;
        this.Player = Player;
    }

    public override void greet()
    {
        Player.PlayerGreeting = Greetings.None;
        StateMachine.CurrentGameState = GameState.CompareGreetings;
    }

    public override void checkInput()
    {
        
    }

    
}
