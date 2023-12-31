using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    private bool isDragged = false;
    private Vector3 offset;

    void Update()
    {
        if (isDragged){
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }
    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragged = true;
    }
    private void OnMouseUp()
    {
        isDragged = false;
    }
}
