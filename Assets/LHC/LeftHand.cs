using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : MonoBehaviour {
    private StateLHC currentState;

    SteamVR_TrackedObject tracked_lefthand;

    public GameObject menu;

    private void Start () {
        SetState(new neutral(this));
        tracked_lefthand = GetComponent<SteamVR_TrackedObject>();
    }

	private void Update () {
        currentState.Tick(tracked_lefthand, menu);
	}

    public void SetState(StateLHC state) {
        if (currentState != null)
            currentState.OnStateExit();

        currentState = state;

        if (currentState != null)
            currentState.OnStateEnter();
    }
}
