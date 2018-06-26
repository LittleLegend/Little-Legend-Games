using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public abstract class Gesture{
    
    public Player Player;

    public StateMachine StateMachine;

    public Vector3 Screenpoint;

    public abstract void greet();

    public abstract void checkInput();

    
    
}
