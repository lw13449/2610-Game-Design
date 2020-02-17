using System;
using UnityEngine;
using UnityEngine.Events;

public class DoorSwitch : MonoBehaviour
{
    public GameObject door;
    public UnityEvent eventAction;

    public void OnTriggerEnter(Collider other)
    {
        door.transform.position = new Vector3(0, 10, 0);
    }
}