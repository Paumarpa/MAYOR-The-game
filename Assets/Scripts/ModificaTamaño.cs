using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModificaTamaño : MonoBehaviour
{
    public float ValorStat = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.localScale = new Vector3(5f, 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(1f, ValorStat, 1f);
    }
}
