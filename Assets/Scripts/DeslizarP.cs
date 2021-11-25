using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeslizarP : MonoBehaviour
{

    //public static int electricidad;

    public GameObject carta;
    public GameObject baraja;
    public cardscript cs;
    public ModificaTamaño stats;

    SpriteRenderer spr;
    public float velCarta = .5f;

    //giro carta
    [SerializeField]

    private Sprite faceSprite, backSprite, barajaSprite;

    private bool coroutineAllowed, facedUp;

    Coroutine lastRoutine;
    /*
    public int restan = 2;
    private static int anyosEnPoder = 0;
    public string stringAnyos = " Años";

    public Text textAnyos;
    */
    [SerializeField] private BaseCarta[] cartasQueUsamos;

    private void SigCarta(int cartaPos)
    {
        cs.cartaDatos = cartasQueUsamos[cartaPos];
    }

    // Start is called before the first frame update
    void Start()
    {
        spr = carta.GetComponent<SpriteRenderer>();


        spr.sprite = faceSprite;
        coroutineAllowed = true;
        facedUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        //rotacion de la carta al moverse
        if (coroutineAllowed)   //no está en la coroutina, por lo que no choca con ello
            carta.transform.rotation = Quaternion.Euler(0f, 0f, -2 * carta.transform.position.x);

       

        if (coroutineAllowed && Input.GetMouseButtonDown(1))
        {
            lastRoutine = StartCoroutine(RotateCard(0.02f));
        }

        
        if (carta.transform.position.x > 2) //PARA LA DERECHA
        {
            cs.descripcionLado.enabled = true;

            cs.descripcionLado.text = cs.cartaDatos.textoDer;
            spr.color = Color.green;
            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("caca");
                int aux = cs.derecha();                //restan--;

                 SigCarta(aux);
                cs.UpdateCartaUI(false);
                //cs.cartaDatos.derElect  - - - - > acceder a las estadisticas de carta
                //aqui se carga siguiente carta
                //tambien se tiene que actualizar el siguiente dorso de la baraja

                spr.sprite = backSprite;
               
                cs.nombreCarta.enabled = false; facedUp = false;cs.descripcionCarta.enabled = false;cs.fondoTexto.enabled = false;cs.imagen.enabled = false;
                
                
                if (coroutineAllowed )
                {
                    StartCoroutine(RotateNewCard());
                }
            }
        }
        else if (carta.transform.position.x < -2)   //PARA LA IZQUIERDA
        {
            cs.descripcionLado.enabled = true;

            cs.descripcionLado.text = cs.cartaDatos.textoIzq;
            spr.color = Color.red;
            if (Input.GetMouseButtonUp(0))
            {
                int aux = cs.izquierda();
                //restan--;

                SigCarta(aux);
                cs.UpdateCartaUI(true);//aqui se carga siguiente carta
                
                //tambien se tiene que actualizar el siguiente dorso de la baraja
                spr.sprite = backSprite;
                facedUp = false;
                cs.imagen.enabled = false;
                cs.nombreCarta.enabled = false;
                cs.descripcionCarta.enabled = false;
                cs.fondoTexto.enabled = false;

                if (coroutineAllowed)
                {
                    StartCoroutine(RotateNewCard());
                }
            }

        }
        else
        {
            cs.descripcionLado.enabled = false;
            spr.color = Color.white;
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
            //carta.transform.rotation = Quaternion.identity; 
        }
    }

    private IEnumerator RotateCard(float tiempoRotacion)
    {
        float tiempoRot = tiempoRotacion;
        coroutineAllowed = false;

        if (!facedUp)
        {
              
            for (float i = 0f; i <= 90f; i += 10f)
            {
                carta.transform.rotation = Quaternion.Euler(0f, i, 0f);
               
                
                yield return new WaitForSeconds(tiempoRot);
            }
            cs.imagen.enabled = true;
            cs.nombreCarta.enabled = true;
            cs.descripcionCarta.enabled = true;
            cs.fondoTexto.enabled = true;

            spr.sprite = faceSprite;
            for (float i = 90f; i >= 0f; i -= 10f)
            {
                carta.transform.rotation = Quaternion.Euler(0f, i, 0f);
                yield return new WaitForSeconds(tiempoRot);
            }
        }
        if (facedUp)
        {
            /*for (float i = 180f; i >= 0f; i -= 10f)
            {
                carta.transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    spr.sprite = backSprite;
                    cs.imagen.enabled = false;
                }
                yield return new WaitForSeconds(0.01f);
            }*/
            for (float i = 0f; i <= 90f; i += 10f)
            {
                carta.transform.rotation = Quaternion.Euler(0f, i, 0f);
                yield return new WaitForSeconds(tiempoRot);
            }
            cs.imagen.enabled = false;
            cs.nombreCarta.enabled = false;
            cs.descripcionCarta.enabled = false;
            cs.fondoTexto.enabled = false;

            spr.sprite = backSprite;

            for (float i = 90f; i >= 0f; i -= 10f)
            {
                carta.transform.rotation = Quaternion.Euler(0f, i, 0f);


                yield return new WaitForSeconds(tiempoRot);
            }

        }
        coroutineAllowed = true;

        facedUp = !facedUp;
    }


    private IEnumerator RotateNewCard()
    {
        yield return new WaitForSeconds(0.5f);//tiempo de espera para girar nueva carta
        coroutineAllowed = false;
        
        if (!facedUp)
        {

            /*for (float i = 0f; i <= 180f; i += 10f)
            {
                carta.transform.rotation = Quaternion.Euler(0f, i, 0f);
                if (i == 90f)
                {
                    spr.sprite = faceSprite;
                    cs.imagen.enabled = true;

                }
                yield return new WaitForSeconds(0.02f);
            }*/
            StartCoroutine(RotateCard(0.02f));
        }
        //coroutineAllowed = true;

        //facedUp = true;
    }
}
