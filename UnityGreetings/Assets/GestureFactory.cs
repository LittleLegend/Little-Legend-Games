using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class GestureFactory{

    
    Player Player;
    StateMachine StateMachine;
    public List<Gesture> GestureList;

   public GestureFactory(Player Player,StateMachine StateMachine)
    {
        this.Player = Player;
        this.StateMachine = StateMachine;
    }
    
    public List<Gesture> createGestureList()
    {
        GestureList = new List<Gesture>();
        GestureList.Add(createBump());
        GestureList.Add(createShake());
        GestureList.Add(createKiss());
        GestureList.Add(createHug());

        return GestureList;
    }

    public Kiss createKiss()
    {
        return new Kiss(Player, StateMachine);
    }
    public Bump createBump()
    {

        return new Bump(Player, StateMachine);
    }
    public Shake createShake()
    {

        return new Shake(Player, StateMachine);
    }
    public Hug createHug()
    {
        return new Hug(Player, StateMachine);
    }

    public None createNone()
    {
        return new None(Player, StateMachine);
    }

}
