using System;
using UnityEngine;
using UnityEngine.Events;

public class DoorSwitch : MonoBehaviour
{
    public GameObject door;
    public UnityEvent eventAction;
    public Animator switchAnimation;
    public CharacterStats bossStats;

    public void OpenDoor()
    {
        Debug.Log("Door is open.");
        door.transform.position = new Vector3(0, 10, 0);
        switchAnimation.SetTrigger("On");
    }

    public void KillBoss()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //kill bossStats currenthealth with damage of 25.
        }
    }
}