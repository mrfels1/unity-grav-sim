using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Mathematics.math;

public class gravityController : MonoBehaviour
{
    //public static float gravitationalConstant = 6.67f * pow(10,-11);
    public GameObject referenceObject;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Rigidbody2D referencerb = referenceObject.GetComponent<Rigidbody2D>();
        Vector2 gravitationalForceVec = default(Vector2);
        float X1 = transform.position.x;
        float Y1 = transform.position.y;
        float X2 = referenceObject.transform.position.x;
        float Y2 = referenceObject.transform.position.y;
        gravitationalForceVec.Set(X2 - X1, Y2 - Y1);
        Vector2 updateVector = gravitationalForceVec * (globalVars.gravitationalConstant * ((rb.mass * referencerb.mass)/(sqrt(pow(X2-X1,2) + pow(Y2 - Y1, 2)))));
        //Debug.Log(updateVector);
        rb.AddForce(updateVector);
    }
}
