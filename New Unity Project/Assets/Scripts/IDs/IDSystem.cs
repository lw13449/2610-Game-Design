using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IDSystem : MonoBehaviour
{
    public List<NameID> IDNameObj;
    public BehaviourID trigger;

    public void Start()
    {
        trigger = GetComponent<BehaviourID>();
    }

    public void OnTriggerEnter(Collider other)
    {
        var nameIdObj = other.GetComponent<BehaviourID>().IDNameObj;
        if (nameIdObj == null) return;
        var otherNameID = nameIdObj;
        
        foreach (var ID in IDNameObj)
        {
            if (ID == otherNameID)
            {
                //do work;
                return;

            }
        }
    }
}