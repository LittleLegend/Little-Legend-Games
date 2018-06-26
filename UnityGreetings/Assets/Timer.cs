using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer{
    
    
    public float Time;
    public bool TimerRunning=true;
    
    public IEnumerator StartTimer(float MaxGreetingTime)
    {
        
        while (Time <= MaxGreetingTime && TimerRunning == true)
        {
            
            yield return new WaitForSeconds(0.01f);
            Time += 0.01f;
            
        }

       if(Time > MaxGreetingTime)
        {
            Time = MaxGreetingTime;
        }

        TimerRunning = false;

    }

    public void EndTimer()
    {
        TimerRunning = false;
    }

    


}
