using System;
using UnityEngine;

public class AttachToPlatform : MonoBehaviour
{
    //public NameID platformId;
    //This goes on the player
    private void OnTriggerEnter(Collider other)
    {
        //var nameIdObj = other.GetComponent<IdBehaviour>().nameIdObj;
        //if (nameIdObj != null &&)
        //{
        //    transform.parent = other.transform;
        //}
        transform.parent = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}