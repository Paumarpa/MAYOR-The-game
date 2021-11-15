using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class BaseCarta : ScriptableObject
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
}
