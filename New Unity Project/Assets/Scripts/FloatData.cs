using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : NameID
{
    public float value;

    public void SetValue(float amount)
    {
        value = amount;
    }

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void ChangeValue(float amount)
    {
        value -= amount;
    }
}