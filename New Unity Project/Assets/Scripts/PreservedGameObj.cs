using System;
using UnityEngine;

public class PreservedGameObj : MonoBehaviour
{
    private static PreservedGameObj heartGameStatus;
    public void Start()
    {
        if (heartGameStatus != null)
        {
            Destroy(this.gameObject);
            return;
        }
        
        heartGameStatus = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
}