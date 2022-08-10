using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleObject : MonoBehaviour
{
    public float highest { get; private set; }
    public Transform Middle;
    void Start()
    {
        highest = Middle.localScale.y;
    }

}
