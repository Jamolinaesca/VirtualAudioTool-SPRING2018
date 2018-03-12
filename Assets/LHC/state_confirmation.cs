using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmation : State {

    public confirmation(LeftHand controller) : base(controller) {
    }

    public override void OnStateEnter() {
        Debug.Log("currentState: confirmation");
    }

    public override void OnStateExit() {
        Debug.Log("exited confirmation state");
    }

    public override void Tick(SteamVR_TrackedObject tracked_lefthand, GameObject menu) {

    }

}
