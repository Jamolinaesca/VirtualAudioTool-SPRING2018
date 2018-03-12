using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : MonoBehaviour {
    private State currentState;

    SteamVR_TrackedObject tracked_lefthand;

    public GameObject controller;

    private void Start () {
        SetState(new neutral(this));
        tracked_lefthand = GetComponent<SteamVR_TrackedObject>();
    }

	private void Update () {
        currentState.Tick(tracked_lefthand);
	}

    public void SetState(State state) {
        if (currentState != null)
            currentState.OnStateExit();

        currentState = state;

        if (currentState != null)
            currentState.OnStateEnter();
    }
}
