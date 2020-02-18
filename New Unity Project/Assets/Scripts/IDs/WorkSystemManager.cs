using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WorkSystemManager : ScriptableObject
{
    [Serializable]
    public struct possibleMatches
    {
        public NameID nameIdObj;
        public WorkSystem workSystemObj;
    }

    public List<possibleMatches> workIdList;
}