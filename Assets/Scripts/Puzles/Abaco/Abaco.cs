using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abaco : MonoBehaviour
{
    private GameObject azul, verde, rojo;
    public GameObject puerta, timer;
    // Start is called before the first frame update
    void Start()
    {
        azul = GameObject.Find("Azul");
        verde = GameObject.Find("Verde");
        rojo = GameObject.Find("Rojo");
    }

    // Update is called once per frame
    public virtual void AbacoMove()
    {
        if(azul.GetComponent<Azul>().n == 9 &&
            verde.GetComponent<Verde>().n == 3 &&
            rojo.GetComponent<Rojo>().n == 4 ){
                puerta.gameObject.transform.Translate(0,-6,0);
                puerta.gameObject.GetComponent<AudioSource>().Play();
                timer.gameObject.GetComponent<Timer>().Detener();
                Destroy(this);
        }
    }
}
