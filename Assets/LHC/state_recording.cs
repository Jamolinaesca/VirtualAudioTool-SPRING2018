using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recording : StateLHC {

    public recording(LeftHand controller) : base(controller) {
    }

    public override void OnStateEnter() {
        Debug.Log("currentState: recording");
    }

    public override void OnStateExit() {
        Debug.Log("exited recording state");
    }

    public override void Tick(SteamVR_TrackedObject tracked_lefthand, GameObject menu) {
        
    }

}
