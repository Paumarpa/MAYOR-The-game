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

    public int izqElect; //Valores pa cuando giras a la izquierda
    public int izqGente;
    public int izqFelic;
    public int izqDinero;
    public int izqComida;
     
    public int derElect; //Valores pa cuando giras a la derecha
    public int derGente;
    public int derFelic;
    public int derDinero;
    public int derComida;

    public Carta()
    {

    }

    public Carta(int ID, string NombreCarta, string DescripcionCarta, Sprite ThisImagen,
                    int IzqElect, int IzqGente, int IzqFelic, int IzqDinero, int IzqComida,
                    int DerElect, int DerGente, int DerFelic, int DerDinero, int DerComida)
    {
        id = ID;
        nombreCarta = NombreCarta;
        descripcionCarta = DescripcionCarta;

        thisImagen = ThisImagen;

        izqElect = IzqElect;
        izqGente = IzqGente;
        izqFelic = IzqFelic;
        izqDinero = IzqDinero;
        izqComida = IzqComida;

        derElect = DerElect;
        derGente = DerGente;
        derFelic = DerFelic;
        derDinero = DerDinero;
        derComida = DerComida;
    }
}
