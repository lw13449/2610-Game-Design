using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Lists : ScriptableObject
{
    public List<string> stringList;
    public List<int> intList;
    public List<float> floatList;
    public List<GameObject> gameObjList;
    public List<FloatData> floatDataList;
}