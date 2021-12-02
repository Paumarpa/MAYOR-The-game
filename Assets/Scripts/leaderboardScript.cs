using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class leaderboardScript : MonoBehaviour
{
    
    string[,] listaPueblos = new string[10, 2] { { "Benicasim", "10 anyos" },
                                                { "Altea", "7 anyos" },
                                                { "Villareal", "6 anyos" },
                                                { "Burjasot", "5 anyos" },
                                                { "Paiporta", "1 anyos" },
                                                { "Benicasim", "10 anyos" },
                                                { "Altea", "7 anyos" },
                                                { "Villareal", "6 anyos" },
                                                { "Burjasot", "5 anyos" },
                                                { "Paiporta", "1 anyos" },
                                                };
    private void Start()
    {
        for (int i = 0; i < listaPueblos.Length/2; i++)
        {
            insertaFila((i+1).ToString(), listaPueblos[i,0], listaPueblos[i, 1]);

        }
    }
    public GameObject prefabFila;
    public Transform padreFila;


    public void insertaFila(string pos, string nombrePueblo, string nAnyos)
    {
        GameObject newGo = Instantiate(prefabFila, padreFila);
        Text[] texts = newGo.GetComponentsInChildren<Text>();
        texts[0].text = pos;
        texts[1].text = nombrePueblo;
        texts[2].text = nAnyos;
    }

    public void Menu()
    {
        SceneManager.LoadScene("ScenaManu");
    }
}
