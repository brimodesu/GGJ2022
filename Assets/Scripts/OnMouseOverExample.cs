using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseOverExample : MonoBehaviour
{

    void OnMouseUp()
    {
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
