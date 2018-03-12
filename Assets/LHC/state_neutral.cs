using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neutral : StateLHC {

    public neutral(LeftHand controller) : base(controller) {
    }

    public override void OnStateEnter() {
        Debug.Log("currentState: neutral");
    }

    public override void OnStateExit() {
        Debug.Log("exited neutral state");
    }

    public override void Tick(SteamVR_TrackedObject tracked_lefthand,  GameObject menu) {

    }

}
