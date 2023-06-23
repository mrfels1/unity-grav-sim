using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllingSimScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            globalVars.gravitationalConstant *= 10f;
            Debug.Log("Current gravitaional constant is " +  globalVars.gravitationalConstant);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            globalVars.gravitationalConstant *= 0.1f;
            Debug.Log("Current gravitaional constant is " + globalVars.gravitationalConstant);
        }
    }
}
