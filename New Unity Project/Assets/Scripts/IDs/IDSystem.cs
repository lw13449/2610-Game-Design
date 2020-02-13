using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IDSystem : MonoBehaviour
{
    public List<NameID> IDNameObj;
    public BehaviourID trigger;
    private NameID nameIdObj;
    public List<DoWork> doWorks;

    public void Start()
    {
        trigger = GetComponent<BehaviourID>();
    }

    public void OnTriggerEnter(Collider other)
    {
        nameIdObj = other.GetComponent<BehaviourID>().IDNameObj;
        CheckID();
        //if (nameIdObj == null) return;
       // var otherNameID = nameIdObj;
    }

    private void CheckID()
    {
        foreach (var obj in IDNameObj)
        {
            if (obj == nameIdObj)
            {
                foreach (var job in doWorks)
                {
                    job.Work();
                }
            }
        }
    }
}