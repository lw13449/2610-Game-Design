using System;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject spawnObj;
    public int spawnNumber = 1;
    public int spawnMax = 3;

    public void Start()
    {
        if (spawnNumber <= spawnMax)
        {
            Vector3 spawnPosition = transform.position;
            Instantiate(spawnObj, spawnPosition, Quaternion.identity);
        }

        if (spawnNumber == spawnMax)
        {
            return;
        }
    }
}