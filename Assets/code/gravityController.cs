using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Mathematics.math;


public class gravityController : MonoBehaviour
{
    //public static float gravitationalConstant = 6.67f * pow(10,-11);

    public float getDistance(GameObject secondObject) {
        return sqrt(pow(this.transform.position.x - secondObject.transform.position.x, 2) +
            pow(this.transform.position.y - secondObject.transform.position.y, 2));
    }
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Fixed update is for physics
    void FixedUpdate()
    {
        
        
        foreach (GameObject planet in globalVars.planetList)
        {
            if(!((this.GetComponent<gravityController>().getDistance(planet)) <= globalVars.sphereOfInfluence) || (this.GetComponent<gravityController>().getDistance(planet)) == 0)
            {
                continue;
            }
            //Debug.Log(this.gameObject.name + " is in sphere of influence Distance: " + this.GetComponent<gravityController>().getDistance(planet));
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Rigidbody2D referencerb = planet.GetComponent<Rigidbody2D>();
            Vector2 gravitationalForceVec = default(Vector2);
            float X1 = transform.position.x;
            float Y1 = transform.position.y;
            float X2 = planet.transform.position.x;
            float Y2 = planet.transform.position.y;
            gravitationalForceVec.Set(X2 - X1, Y2 - Y1);
            Vector2 updateVector = gravitationalForceVec * (globalVars.gravitationalConstant * ((rb.mass * referencerb.mass)/(this.getDistance(planet))));
            if (updateVector.x != float.NaN)
            {
                rb.AddForce(updateVector);
            }   
        }
    }
}
