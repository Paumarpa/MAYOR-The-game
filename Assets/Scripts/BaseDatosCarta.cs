using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDatosCarta : MonoBehaviour
{
    public static List<Carta> Listacartas = new List<Carta>();

    void Awake()
    {                                                                                                 //Valores Izquierda,  Valores Derecha
        Listacartas.Add(new Carta(0, "TestElectricidad", "Afecta a electricidad", Resources.Load <Sprite>("0"), 0,0,0,0,0, 0,0,0,0,0));
        Listacartas.Add(new Carta(1, "TestGente", "Afecta a gente", Resources.Load<Sprite>("1"), 0,0,0,0,0, 0,0,0,0,0));
        Listacartas.Add(new Carta(2, "TestFelicidad", "Afecta a felicidad", Resources.Load<Sprite>("2"), 0,0,0,0,0, 0,0,0,0,0));
        Listacartas.Add(new Carta(3, "TestDinero", "Afecta a dinero", Resources.Load<Sprite>("3"), 0,0,0,0,0, 0,0,0,0,0));
        Listacartas.Add(new Carta(4, "TestComida", "Afecta a comida", Resources.Load<Sprite>("4"), 0,0,0,0,0, 0,0,0,0,0));
    }
}
