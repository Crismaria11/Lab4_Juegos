using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContarMonedas : MonoBehaviour
{
    public int puntuacion = 0;
    public Text TxtContador;


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Blancos"))
        {
            puntuacion += 1;
            TxtContador.text = puntuacion.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
