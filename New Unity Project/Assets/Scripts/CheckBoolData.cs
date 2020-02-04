using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoolData : MonoBehaviour
{
    public BoolData boolDataObj;

   
    void Update()
    {
        if (boolDataObj.value)
        {
            print("true");
            //work to do
        }
        else
        {
            //do false work
        }
    }
}
