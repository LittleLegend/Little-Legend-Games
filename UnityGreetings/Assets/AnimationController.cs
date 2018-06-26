using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class AnimationController : MonoBehaviour {

    public Animator Doorstep_Animator;
    public Animator Guest_Animator;
    public Animator Scene_Animator;
    public Animator Clock_Animator;
    public SpriteRenderer SceneRenderer;
    public SpriteRenderer GreetingRenderer;
    
    public void OpenDoorAnimation(People CurrentGuest)
    {
        Doorstep_Animator.SetBool("DoorOpen", true);
        SetClock(1, CurrentGuest.MaxGreetingTime);
        
    }

    public void WatchSceneAnimation(People CurrentGuest, Greetings PlayerGreeting)
    {
        EnableScene(true);
        PlaySceneRole(CurrentGuest, PlayerGreeting);
        SetClock(0, 0);

    }

    
    public void CloseDoorAnimation()
    {
        Doorstep_Animator.SetBool("DoorOpen", false);
        EnableScene(false);
        Scene_Animator.SetInteger("Scene", 0);

    }

    public bool IsDoorClosed()
    {
        if (Doorstep_Animator.GetCurrentAnimatorStateInfo(0).IsName("Door_Close_Still"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsDoorOpen()
    {
        if (Doorstep_Animator.GetCurrentAnimatorStateInfo(0).IsName("Door_Open_Still"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SetClock(int running, float seconds)
    {
        Clock_Animator.SetInteger("Running", running);
        Clock_Animator.SetFloat("Speed", 5/seconds);
    }
    public void SetGuest(Roles Role)
    {
        switch (Role)
        {
            case Roles.Wife:
                Guest_Animator.SetInteger("Guest", 1);
                break;

            case Roles.Friend:
                Guest_Animator.SetInteger("Guest", 2);
                break;

            case Roles.Boss:
                Guest_Animator.SetInteger("Guest", 3);
                break;
                
            case Roles.Mother:
                Guest_Animator.SetInteger("Guest", 4);
                break;
        }
    } 
    public void EnableScene(bool Enabled)
    {
        {
            SceneRenderer.enabled = Enabled;
           GreetingRenderer.enabled = Enabled;

        }
    }
    

    public void PlaySceneRole(People People, Greetings PlayerGreeting)
    {
        switch(People.Type)
        {
            case Roles.Wife:

                PlaySceneWife(People, PlayerGreeting);

                break;

            case Roles.Boss:

                PlaySceneBoss(People,PlayerGreeting);

                break;

            case Roles.Friend:

                PlaySceneFriend(People, PlayerGreeting);

                break;

            case Roles.Mother:

                PlaySceneMother(People, PlayerGreeting);

                break;

        }
    }
    public void PlaySceneWife(People People,Greetings PlayerGreeting)
    {
        
                if (People.WantedGreeting == PlayerGreeting)
                {
                    Scene_Animator.SetInteger("Scene", 1);
                }else
                {
                    Scene_Animator.SetInteger("Scene", 2);
                }

    }
    public void PlaySceneFriend(People People,Greetings PlayerGreeting)
    {
        if (People.WantedGreeting == PlayerGreeting)
        {
            Scene_Animator.SetInteger("Scene", 3);
        }
        else
        {
            Scene_Animator.SetInteger("Scene", 4);
        }
    }
    public void PlaySceneMother(People People,Greetings PlayerGreeting)
    {
        if (People.WantedGreeting == PlayerGreeting)
        {
            Scene_Animator.SetInteger("Scene", 5);
        }
        else
        {
            Scene_Animator.SetInteger("Scene", 6);
        }
    }
    public void PlaySceneBoss(People People,Greetings PlayerGreeting)
    {
        if (People.WantedGreeting == PlayerGreeting)
        {
            Scene_Animator.SetInteger("Scene", 7);
        }
        else
        {
            Scene_Animator.SetInteger("Scene", 8);
        }
    }

  


}
