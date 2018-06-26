using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

    public class People
    {

        
        
        public Greetings WantedGreeting;
        public Roles Type;
        public bool Greeted=false;
        public bool GreetedRight;
        public float GreetingTime;
        public float MaxGreetingTime;
        public int points;
        public int combo;
       
    public void SetGreetedRight(bool GreetedRight)
    {
        Greeted = true;
        this.GreetedRight = GreetedRight;
    }

    public void SetGreetingTime(float GreetingTime)
    {
        this.GreetingTime = GreetingTime;
    }



}
