using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        globalVars.planetList.Add(this.gameObject);
        Debug.Log("Default object inserted into planet list");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
