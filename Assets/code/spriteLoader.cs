using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = Resources.Load<Sprite>("Assets / Sprites / Circle.asset"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
