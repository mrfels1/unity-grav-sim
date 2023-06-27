using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllingSimScript : MonoBehaviour
{
    public void createPlanetObject(float x, float y)
    {
        GameObject newObject = new GameObject();
        newObject.layer = 0;
        newObject.AddComponent<SpriteRenderer>();
        newObject.AddComponent<Rigidbody2D>();
        newObject.AddComponent<CircleCollider2D>();
        newObject.AddComponent<gravityController>();
        newObject.AddComponent<drag>();
        newObject.AddComponent<planetObject>();
        newObject.AddComponent<spriteLoader>();

        System.Random rnd = new System.Random();
        int num = rnd.Next();

        newObject.name = "Planet" + num.ToString().Substring(10);//setting random number name

        SpriteRenderer spriteRenderer = newObject.GetComponent<SpriteRenderer>();
        Rigidbody2D rigidbody = newObject.GetComponent<Rigidbody2D>();

        


        planetObject planetObject = newObject.GetComponent<planetObject>();
        planetObject.density = Random.Range(0f, 1.0f); //setting density
        planetObject.name = newObject.name; //setting name

        newObject.transform.position = new UnityEngine.Vector3(x, y, 0);
        globalVars.planetList.Add(newObject);
        Debug.Log("Planet:\"" + newObject.name + "\" with density of "+ planetObject.density + " has been created!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            globalVars.gravitationalConstant *= 10f;
            Debug.Log("Current gravitaional constant is " + globalVars.gravitationalConstant);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            globalVars.gravitationalConstant *= 0.1f;
            Debug.Log("Current gravitaional constant is " + globalVars.gravitationalConstant);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            createPlanetObject(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        }
    }
}
