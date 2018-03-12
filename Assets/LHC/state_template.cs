using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State {
    protected LeftHand controller;

    public abstract void Tick(SteamVR_TrackedObject tracked_lefthand, GameObject menu);
    public virtual void OnStateEnter() { }
    public virtual void OnStateExit() { }

    public State(LeftHand state) {
        this.controller = state;
    }
}
