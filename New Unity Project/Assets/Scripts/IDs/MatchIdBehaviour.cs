using System;
using System.Collections.Generic;
using UnityEngine;

public class MatchIdBehaviour : IdBehaviour
{
    [Serializable]
    public struct possibleMatches
    {
        public NameID nameIdObj;
        public WorkSystem workSystemObj;
    }

    public List<possibleMatches> workIdList;
}