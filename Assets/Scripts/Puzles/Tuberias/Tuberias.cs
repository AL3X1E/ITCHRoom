using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Tuberias : MonoBehaviour
{
    public GameObject[] tubos = new GameObject[11];
    public GameObject nota, puerta;
    private Boolean completado = false;
    public virtual void Comprobacion()
    {
    if(
    tubos[0].gameObject.GetComponent<Contador2>().getCont() == 1 &&
    tubos[1].gameObject.GetComponent<Contador2>().getCont() == 1 &&
    tubos[2].gameObject.GetComponent<Contador2>().getCont() == 1 &&
    tubos[3].gameObject.GetComponent<Contador>().getCont() == 1 &&
    tubos[4].gameObject.GetComponent<Contador>().getCont() == 1 &&
    tubos[5].gameObject.GetComponent<Contador>().getCont() == 1 &&
    tubos[6].gameObject.GetComponent<Contador2>().getCont() == 1 &&
    tubos[7].gameObject.GetComponent<Contador2>().getCont() == 1 &&
    tubos[8].gameObject.GetComponent<Contador>().getCont() == 1 &&
    tubos[9].gameObject.GetComponent<Contador2>().getCont() == 1 &&
    tubos[10].gameObject.GetComponent<Contador2>().getCont() == 1
    ){
        Debug.Log("Correcto");
        GetComponent<AudioSource>().Play();
       nota.gameObject.transform.Translate(0,0,-0.2f); 
       completado = true;
       puerta.GetComponent<Puerta>().setJ1(true);
       puerta.GetComponent<Puerta>().Desbloqueo();
       Destroy(this);
    } else {
        Debug.Log("No se ha Resuelto");
    }
    }
    public Boolean c(){
        return completado;
    }
}
