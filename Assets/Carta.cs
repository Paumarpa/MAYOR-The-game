using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Carta : MonoBehaviour
{
    public int id;
    public string nombreCarta;
    public string descripcionCarta;

    public Carta()
    {

    }

    public Carta(int ID, string NombreCarta, string DescripcionCarta)
    {
        id = ID;
        nombreCarta = NombreCarta;
        descripcionCarta = DescripcionCarta;
    }
}
