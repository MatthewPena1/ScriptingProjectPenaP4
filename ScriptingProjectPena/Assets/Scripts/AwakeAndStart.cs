using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    void Awake()
        //set an initialization (set something before an object is done)
    {
        Debug.Log("Awake called.");
    }

    void Start()
        //action occurs when component is enabled
    {
        Debug.Log("Start called.");
    }
}
