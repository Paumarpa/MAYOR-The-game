using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarajaJugador : MonoBehaviour
{

    public List<Carta> baraja = new List<Carta>();

    public int x;
    public int tama�oBaraja;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        tama�oBaraja = 40;

        for (int i = 0; i < tama�oBaraja; i++)
        {
            x = Random.Range(0, 5); //rango id cartas de BaseDatosCartas
            baraja[i] = BaseDatosCarta.Listacartas[x];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
