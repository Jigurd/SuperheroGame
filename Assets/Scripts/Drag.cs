using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Drag : MonoBehaviour
{
    private Vector3 _screenPoint;
    private Vector3 _offset;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            _offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + _offset;
        transform.parent.parent.position = cursorPosition;
    }

}

