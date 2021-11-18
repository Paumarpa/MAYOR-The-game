using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardscript : MonoBehaviour
{
    public bool isMouseOver = false;
    public bool isDragging = false;
    private void OnMouseOver()
    {
        isMouseOver = true;
    }

     private void OnMouseDrag()
    {
        isDragging = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;

    }

    public void izquierda()
    {
        Debug.Log("has escogida izquierda");

    }

    public void derecha()
    {
        Debug.Log("derecha");
    }
}