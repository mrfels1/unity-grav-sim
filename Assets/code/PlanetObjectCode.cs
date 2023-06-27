using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetObject : MonoBehaviour
{
    public string planetName;
    public float density = 1;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is planet " + planetName);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        rb.mass = 1 * sr.bounds.size.x * density;
        Debug.Log(planetName + "'s mass is " + rb.mass);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
