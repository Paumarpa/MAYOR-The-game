using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDatosCarta : MonoBehaviour
{
    public static List<Carta> Listacartas = new List<Carta>();

    void Awake()
    {                                                                                                 //Valores Izquierda,  Valores Derecha
        Listacartas.Add(new Carta(0, "TestElectricidad", "Afecta a electricidad", Arte.Load <Sprite>("0"), 0,0,0,0,0, 0,0,0,0,0));
        Listacartas.Add(new Carta(1, "TestGente", "Afecta a gente", Arte.Load<Sprite>("1"), 0,0,0,0,0, 0,0,0,0,0));
        Listacartas.Add(new Carta(2, "TestFelicidad", "Afecta a felicidad", Arte.Load<Sprite>("2"), 0,0,0,0,0, 0,0,0,0,0));
        Listacartas.Add(new Carta(3, "TestDinero", "Afecta a dinero", Arte.Load<Sprite>("3"), 0,0,0,0,0, 0,0,0,0,0));
        Listacartas.Add(new Carta(4, "TestComida", "Afecta a comida", Arte.Load<Sprite>("4"), 0,0,0,0,0, 0,0,0,0,0));
    }
}
