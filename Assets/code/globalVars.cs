using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Mathematics.math;

public class globalVars : MonoBehaviour
{
    public static float gravitationalConstant;
    public bool useRealWorldConstant = false;
    void Start()
    {
        if (useRealWorldConstant)
        {
            gravitationalConstant = 6.67f * pow(10, -11);
        }
        else
        {
            gravitationalConstant = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
