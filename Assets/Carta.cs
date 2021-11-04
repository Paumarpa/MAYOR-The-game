using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Carta
{
    public int id;
    public string nombreCarta;
    public string descripcionCarta;

    public Sprite thisImagen;

    public Carta()
    {

    }

    public Carta(int ID, string NombreCarta, string DescripcionCarta, Sprite ThisImagen)
    {
        id = ID;
        nombreCarta = NombreCarta;
        descripcionCarta = DescripcionCarta;

        thisImagen = ThisImagen;
    }
}
