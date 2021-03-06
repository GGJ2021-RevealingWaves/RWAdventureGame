using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class RegionStepper : MonoBehaviour
{
    public Region currentRegion;
    private void OnCollisionStay2D(Collision2D other)
    {
        Region region = other.gameObject.GetComponent<Region>();
        currentRegion = region;
        if (region != null && region!=Region.ActiveRegion)
        {
            Region.UpdateActiveRegion(region);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        AudioTriggerOncePoint trigger = other.gameObject.GetComponent<AudioTriggerOncePoint>();
        if (trigger != null)
        {
            trigger.PlayLine();
        }
    }
}
