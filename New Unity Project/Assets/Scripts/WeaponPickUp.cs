using System;
using System.Collections;
using UnityEngine;
using Object = System.Object;

public class WeaponPickUp : MonoBehaviour
{
    public GameObject shield;
    public GameObject groundFuryAttack;
    public GameObject furyAttack;
    public GameObject groundHammerSmash;
    public GameObject hammerSmash;
    public GameObject UI;
    public GameObject groundShield;
    

    public void Start()
    {
        Vector3 fwd = transform.TransformDirection((Vector3.forward));
        RaycastHit hit = new RaycastHit();
        //Ray ray;
        if (Physics.Raycast(transform.position, fwd, out hit))
        {
            if (hit.collider.tag == "shield")
            {
                UI.SetActive(true);//the text gameobject.
                if (Input.GetKeyDown(KeyCode.F))//to pickup the hammer
                {
                    groundShield.SetActive(false);
                    shield.SetActive(true);
                }
            }
            else
            {
                UI.SetActive(false);
            }

            if (hit.collider.tag == "hammersmash")
            {
                UI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.D))
                {
                    groundHammerSmash.SetActive(false);
                    hammerSmash.SetActive(true);
                }
            }
            else
            {
                UI.SetActive(false);
            }

            if (hit.collider.tag == "furyattack")
            {
                UI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.G))
                {
                    groundFuryAttack.SetActive(false);
                    furyAttack.SetActive(true);
                }
            }
            else
            {
                UI.SetActive(false);
            }
        }
    }
}