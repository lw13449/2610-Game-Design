using System;
using UnityEngine;
using UnityEngine.Events;

public class DoorSwitch : MonoBehaviour
{
    public GameObject door;
    public UnityEvent eventAction;

    public void OnTriggerEnter(Collider other)
    {
        eventAction.Invoke();
    }
}