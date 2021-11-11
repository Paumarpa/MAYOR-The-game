using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giroCarta : MonoBehaviour
{
    public GameObject carta;

    private SpriteRenderer rend;

    [SerializeField]

    private Sprite faceSprite, backSprite;

    private bool coroutineAllowed, facedUp;


    Coroutine lastRoutine;


    // Start is called before the first frame update
    void Start()
    {
        rend = carta.GetComponent<SpriteRenderer>();
        //rend.sprite = backSprite;
        coroutineAllowed = true;
        facedUp = true;
    }

    private void Update()
    {
        if (coroutineAllowed && Input.GetMouseButtonDown(1) )
        {
            lastRoutine = StartCoroutine(RotateCard());
        }
    }


    private IEnumerator RotateCard()
    {
        
        coroutineAllowed = false;

        if (!facedUp)
        {
            for (float i =0f; i<= 180f; i+= 10f)
            {
                carta.transform.rotation = Quaternion.Euler(0f, i, 0f);
                if(i == 90f)
                {
                    rend.sprite = faceSprite;
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
                    rend.sprite = backSprite;
                }
                yield return new WaitForSeconds(0.01f);
            }
                
        }
        coroutineAllowed = true;

        facedUp = !facedUp;

    }
}