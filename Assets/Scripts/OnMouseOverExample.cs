using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseOverExample : MonoBehaviour
{
    
    void OnMouseDown()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
        if (Input.GetMouseButtonDown(0))
        {
         
                //RaycastHit hit = castRay();
                // if (hit.collider != null)
                // {
                //     if (!hit.collider.CompareTag("Drag"))
                //     {
                //         return;
                //     }
                    
                   
                //}
              
        }
    }

    void OnMouseUp()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
        Cursor.visible = true;
        GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnMouseDrag()
    {
        
        Cursor.visible = false;
        GetComponent<Rigidbody>().useGravity = false;
        Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Camera.main.WorldToScreenPoint(transform.position).z);
        
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);

        transform.position = new Vector3(worldPosition.x,
            2.25f, worldPosition.z);
    }
    
}
