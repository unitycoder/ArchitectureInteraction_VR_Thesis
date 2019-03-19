﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR;

public abstract class Interactable : MonoBehaviour
{
    public SteamVR_Behaviour_Pose controllerPose;
    public Transform user;
    protected bool grabbed;
    public GameObject ghostHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void HandleEnter(SteamVR_Behaviour_Pose pose);

    public abstract void HandleExit();

    public abstract void HandleStay(Vector3 hitPoint);

    public abstract void ShowHighlight();

    public abstract void HideHighlight();

    public abstract void HandleButtonClickDown();

    public abstract void HandleButtonClickHold();

    public abstract void HandleButtonClickUp();

    public abstract void HandleTriggerDown(Vector3 hitPoint);

    public abstract void HandleTriggerHold();

    public abstract void HandleTriggerUp();

}
