using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



[Serializable]
public class WorldResource
{
    public ResourceTypes Type;
    public Color ResourceColor;

}

[Serializable]
    public enum ResourceTypes
    {
        Coal,
        Solid,
        Water,
        Gold
    }




