using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInputCommand : ICommand {

    public Gesture Gesture;


    public CheckInputCommand(Gesture Gesture)
    {
        this.Gesture = Gesture;
    }

    public void execute()
    {
        Gesture.checkInput();
    }

    
}
