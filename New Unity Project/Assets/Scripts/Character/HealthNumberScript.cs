using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthNumberScript : MonoBehaviour
{
    public FloatData healthValue;

    private Text health;

    public void Start()
    {
        health = GetComponent<Text>();
    }

    public void Update()
    {
        health.text = "health" + healthValue.value;
    }
}