using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDatosCarta : MonoBehaviour
{
    public static List<Carta> Listacartas = new List<Carta>();

    void Awake()
    {
        Listacartas.Add(new Carta(0, "TestElectricidad", "Afecta a electricidad"));
        Listacartas.Add(new Carta(1, "TestGente", "Afecta a gente"));
        Listacartas.Add(new Carta(2, "TestFelicidad", "Afecta a felicidad"));
        Listacartas.Add(new Carta(3, "TestDinero", "Afecta a dinero"));
        Listacartas.Add(new Carta(4, "TestComida", "Afecta a comida"));
    }
}
