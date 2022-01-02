using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isDragged = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;
    private void OnMouseDown()
    {
      isDragged = true;
    }

    private void OnMouseDrag() {

    }

    private void OnMouseUp() {

    }
}
