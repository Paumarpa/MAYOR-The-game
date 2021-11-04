using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardscript : MonoBehaviour
{
    public bool isMouseOver = false;
    private void OnMouseOver()
    {
        isMouseOver = true;
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