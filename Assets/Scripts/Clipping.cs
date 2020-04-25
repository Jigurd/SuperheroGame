using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clipping : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Doot");
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.parent.parent.position = cursorPosition;
    }

}

