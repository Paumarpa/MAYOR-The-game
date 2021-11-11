using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarajaJugador : MonoBehaviour
{

    public List<Carta> baraja = new List<Carta>();

    public int x;
    public int tamañoBaraja;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        tamañoBaraja = 40;

        for (int i = 0; i < tamañoBaraja; i++)
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
