using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRubyShared;

public class GestureAdapter{

    FingersScript FingersScript;
    TapGestureRecognizer tapgesture;
    LongPressGestureRecognizer longpressgesture;
    SwipeGestureRecognizer swipegesture;
    ScaleGestureRecognizer scalegesture;

    public GestureAdapter(FingersScript fingersScript)
    {
        FingersScript = fingersScript;
    }
    

    public void CreateTab(GestureRecognizerStateUpdatedDelegate gestureRecognizerStateUpdatedDelegate)
    {
        tapgesture = new TapGestureRecognizer();
        tapgesture.StateUpdated += gestureRecognizerStateUpdatedDelegate;
        FingersScript.AddGesture(tapgesture);
        
    }

    public void CreateLongPress(GestureRecognizerStateUpdatedDelegate gestureRecognizerStateUpdatedDelegate)
    {
        longpressgesture = new LongPressGestureRecognizer();
        longpressgesture.StateUpdated += gestureRecognizerStateUpdatedDelegate;
        FingersScript.AddGesture(longpressgesture);

    }

    public void CreateSwipe(GestureRecognizerStateUpdatedDelegate gestureRecognizerStateUpdatedDelegate)
    {
        swipegesture = new SwipeGestureRecognizer();
        swipegesture.StateUpdated += gestureRecognizerStateUpdatedDelegate;
        FingersScript.AddGesture(swipegesture);

    }

    public void CreateScale(GestureRecognizerStateUpdatedDelegate gestureRecognizerStateUpdatedDelegate)
    {
        scalegesture = new ScaleGestureRecognizer();
        scalegesture.StateUpdated += gestureRecognizerStateUpdatedDelegate;
        FingersScript.AddGesture(scalegesture);

    }



    public void RemoveTab()
    {
        FingersScript.RemoveGesture(tapgesture);
        FingersScript.RemoveGesture(longpressgesture);
        FingersScript.RemoveGesture(swipegesture);
        FingersScript.RemoveGesture(scalegesture);
    }

}
