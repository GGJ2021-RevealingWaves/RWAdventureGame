using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu(fileName = "New Fade Interaction", menuName = "Interactions/Fade Interaction")]
public class FadeBlackInteraction : ItemObjectInteraction
{
    private BlackCover cover;

    [SerializeField] private Item itemToRemove;
    [SerializeField] private bool removeInteractedObject;
    [SerializeField] private List<Spawnable> objectsToSpawn;
    [SerializeField] public AudioClip toPlay;
    [SerializeField] private Sprite newPlayerSprite;

    public override void Act(InteractibleObject from)
    {
        cover = FindObjectOfType<BlackCover>();
        if (from == null) removeInteractedObject = false;
        cover.StartSequence(from, itemToRemove, removeInteractedObject, objectsToSpawn, toPlay, newPlayerSprite);
    }

    
}

[System.Serializable]
public class Spawnable
{
    public Transform toSpawn;
    public Vector3 spawnLocation;
}