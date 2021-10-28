using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThisCarta : MonoBehaviour
{
    public List<Carta> thisCarta = new List<Carta>();
    public int thisId;

    public int id;
    public string nombreCarta;
    public string descripcionCarta;

    public Text nameText;
    public Text descText;
    // Start is called before the first frame update
    void Start()
    {
        thisCarta[0] = BaseDatosCarta.Listacartas[thisId];

    }

    // Update is called once per frame
    void Update()
    {
        id = thisCarta[0].id;
        nombreCarta = thisCarta[0].nombreCarta;
        descripcionCarta = thisCarta[0].descripcionCarta;

        nameText.text = "" + nombreCarta;
        descText.text = "" + descripcionCarta;
    }
}
