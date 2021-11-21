using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class cardscript : MonoBehaviour
{
    public BaseCarta cartaDatos;
    private SpriteRenderer spriteCarta;

    public bool isMouseOver = false;
    public bool isDragging = false;

    [SerializeField]public TextMeshProUGUI nombreCarta;
    [SerializeField] public TextMeshProUGUI descripcionCarta;
    [SerializeField] public SpriteRenderer fondoTexto;
    [SerializeField] public Image imagen;

    private void Start()
    {
        spriteCarta = GetComponent<SpriteRenderer>();

        UpdateCartaUI();
    }
  
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


    public int izquierda()
    {
        //cartaDatos.luz += cartaDatos.izqElect;
       // Debug.Log("has escogida izquierda");
        Debug.Log(cartaDatos.id + "es mi id jeje");

        return cartaDatos.sigID;
    }

    public int derecha()
    {
        // Debug.Log("derecha");
        return cartaDatos.sigID;//cambiar a derecha


    }

    public void UpdateCartaUI()
    {
        nombreCarta.text = cartaDatos.nombreCarta;
        descripcionCarta.text = cartaDatos.descripcionCarta;

        imagen.sprite = cartaDatos.imagen;

       if (cartaDatos.aleatoria)
            SetSigID();
    }

    private void SetSigID()
    {
        int aleatorioID = Random.Range(3, 6);
        while(cartaDatos.id == aleatorioID)//solo par no pillarse a si misma//poner condicion cartas prohibidas//mirar como hacer un array xD

        {
            aleatorioID = Random.Range(3, 6);
        }
        cartaDatos.sigID = aleatorioID;
    }
}