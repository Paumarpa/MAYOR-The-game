using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deslizar : MonoBehaviour
{

    //public static int electricidad;

    public GameObject carta;
    public cardscript cs;
    SpriteRenderer spr;
    public float velCarta = .5f;

    // Start is called before the first frame update
    void Start()
    {
        spr = carta.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {



        if (carta.transform.position.x > 2)
        {
            spr.color = Color.green;

        }

        else if (carta.transform.position.x < -2)
        {
            spr.color = Color.red;
            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("kk");
                cs.izquierda();
            }

        }

        else
        {

            spr.color = Color.white;
        }
        //Debug.Log(electricidad);
        //electricidad++;

        if (Input.GetMouseButtonUp(0))
        {
            if (carta.transform.position.x > 2)
            {
                Debug.Log("caca");
                cs.derecha();
            }
        }

        if (Input.GetMouseButton(0) && cs.isMouseOver)
        {

            Vector2 posicion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            carta.transform.position = posicion;
            //spr.color = Color.green;
        }
        else
        {
            carta.transform.position = Vector2.MoveTowards(transform.position, new Vector2(0, 0), velCarta);
        }
    }
}