using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    public TextMeshProUGUI componeneteTexto;
    public string[] frases;
    public float velocidadLetras;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        componeneteTexto.text = string.Empty;
        empezarDialogo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void empezarDialogo()
    {
        index = 0;
        StartCoroutine(escribeFrases());
    }

    IEnumerator escribeFrases()
    {
        foreach(char c in frases[index].ToCharArray())
        {
            componeneteTexto.text += c;
            yield return new WaitForSeconds(velocidadLetras);
        }
    }
}
