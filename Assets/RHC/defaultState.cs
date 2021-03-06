﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultState : StateRHC
{
    public static defaultState instance;

    Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;      //getting a call directly from the trigger and mapping to a variable
    Valve.VR.EVRButtonId touchpadButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;    //getting a call directly from the touchpad and mapping to a variable

    public defaultState(RightHand controller) : base(controller) {
    }

    public override void OnStateEnter()
    {
        Debug.Log("You are on the default state right now!");
    }

    public override void OnStateExit()
    {
        Debug.Log("You've exited the default state!");
    }

    public override void Tick(SteamVR_TrackedObject trackedObj, SteamVR_Controller.Device rightHand, GameObject hand, GameObject mic)
    {
        rightHand = SteamVR_Controller.Input((int)trackedObj.index); //get integer representation of the controller

        if (rightHand.GetPressDown(triggerButton))
        {
            Debug.Log("Select!");
        }
        else if (rightHand.GetPressDown(touchpadButton))
        {
            Debug.Log("You have placed the note");


        }
    }

    public void ChangeState()
    {
        Debug.Log("Hey!");
        controller.SetState(new recordingState(controller));
    }
}
