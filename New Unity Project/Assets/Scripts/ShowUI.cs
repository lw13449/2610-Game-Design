using System;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject uIObj;
    public GameObject player;

    public void Start()
    {
        uIObj.SetActive(false);
        player = GameObject.Find("Player");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (player = other.gameObject)
        {
            uIObj.SetActive(true);
        }
    }
}