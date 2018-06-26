using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using System;

public  class GreetCommand:ICommand
{

    public Gesture Gesture;

    
    public GreetCommand(Gesture Gesture)
    {
        this.Gesture = Gesture;
    }

    public void execute()
    {
        Gesture.greet();
    }
 
}
