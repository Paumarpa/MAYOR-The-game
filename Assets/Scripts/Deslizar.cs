using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deslizar : MonoBehaviour
{

    //public static int electricidad;

    public GameObject carta;

    public cardscript cs;
    public ModificaTamaño stats;

    SpriteRenderer spr;
    public float velCarta = .5f;

    
    //giro carta
    [SerializeField]

    private Sprite faceSprite, backSprite;

    private bool coroutineAllowed, facedUp;

    Coroutine lastRoutine;
    
    public int restan = 2;
    private static int anyosEnPoder = 0;
    public string stringAnyos = " Años";

    public Text textAnyos;
    

    // Start is called before the first frame update
    void Start()
    {
        spr = carta.GetComponent<SpriteRenderer>();

     
        spr.sprite = backSprite;
        coroutineAllowed = true;
        facedUp = true;

    }

    // Update is called once per frame
    void Update()
    {
        //rotacion de la carta al moverse
        carta.transform.rotation = Quaternion.Euler(0f, 0f, -2 * carta.transform.position.x);

        if (coroutineAllowed && Input.GetMouseButtonDown(1))
        {
            lastRoutine = StartCoroutine(RotateCard());
        }

        if (carta.transform.position.x > 2)
        {
            spr.color = Color.green;
            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("caca");
                cs.derecha();
                restan--;
            }
        }

        else if (carta.transform.position.x < -2)
        {
            spr.color = Color.red;
            if (Input.GetMouseButtonUp(0))
            {
                cs.izquierda();
                restan--;
            }

        }

        else
        {
            spr.color = Color.white;
        }

        if (restan <= 0)
        {
            restan = 2;
            anyosEnPoder++;
            if (textAnyos != null)
            {
                textAnyos.text = anyosEnPoder.ToString() + stringAnyos;
            }
        }

        if (Input.GetMouseButtonUp(0))

        {
            {
  
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

    private IEnumerator RotateCard()
    {

        coroutineAllowed = false;

        if (!facedUp)
        {
            for (float i = 0f; i <= 180f; i += 10f)
            {
                carta.transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    spr.sprite = faceSprite;
                }
                yield return new WaitForSeconds(0.01f);
            }
        }
        if (facedUp)
        {
            for (float i = 180f; i >= 0f; i -= 10f)
            {
                carta.transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    spr.sprite = backSprite;
                }
                yield return new WaitForSeconds(0.01f);
            }

        }
        coroutineAllowed = true;

        facedUp = !facedUp;

    }
}