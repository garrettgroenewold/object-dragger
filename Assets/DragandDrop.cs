using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDrop : MonoBehaviour
{
    Vector3 mousePostion;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePostion = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag()
    {       
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePostion);
        }
    }

}
