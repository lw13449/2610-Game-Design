using System;
using UnityEngine;
using UnityEngine.Events;

public class DoorSwitch : MonoBehaviour
{
    public GameObject door;
    public UnityEvent eventAction;
    public Animator switchAnimation;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Door is open.");
        door.transform.position = new Vector3(0, 10, 0);
        switchAnimation.SetTrigger("Open Door");
    }

    public void KillBoss()
    {
        
    }
}