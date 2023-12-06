using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour
{
    private GameObject[] cuadro = new GameObject[9];
    public GameObject nota, puerta;
    public Boolean completado;
    void Start(){
        cuadro[0] = GameObject.Find("1x1");
        cuadro[1] = GameObject.Find("1x2");
        cuadro[2] = GameObject.Find("1x3");
        cuadro[3] = GameObject.Find("2x1");
        cuadro[4] = GameObject.Find("2x2");
        cuadro[5] = GameObject.Find("2x3");
        cuadro[6] = GameObject.Find("3x1");
        cuadro[7] = GameObject.Find("3x2");
        cuadro[8] = GameObject.Find("3x3");
    }
    public void Comprobar()
    {
        //Horizontal
        if(
        cuadro[0].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[1].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[2].gameObject.GetComponent<Gato>().GetJugador() == 1
        ){
            Completado();
        }
        if(
        cuadro[3].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[4].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[5].gameObject.GetComponent<Gato>().GetJugador() == 1
        ){
            Completado();
        }
        if(
        cuadro[6].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[7].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[8].gameObject.GetComponent<Gato>().GetJugador() == 1
        ){
            Completado();
        }
        //Vertical
        if(
        cuadro[0].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[3].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[6].gameObject.GetComponent<Gato>().GetJugador() == 1
        ){
            Completado();
        }
        if(
        cuadro[1].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[4].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[7].gameObject.GetComponent<Gato>().GetJugador() == 1
        ){
           Completado();
        }
        if(
        cuadro[2].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[5].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[8].gameObject.GetComponent<Gato>().GetJugador() == 1
        ){
            Completado();
        }
        //Diagonal
        if(
        cuadro[0].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[4].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[8].gameObject.GetComponent<Gato>().GetJugador() == 1
        ){
            Completado();
        }
        if(
        cuadro[2].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[4].gameObject.GetComponent<Gato>().GetJugador() == 1 &&
        cuadro[6].gameObject.GetComponent<Gato>().GetJugador() == 1
        ){
            Completado();
        }
    }
    void Completado(){
            Debug.Log("Completado");
            for(int i = 0; i > 9; i++){
                cuadro[i].gameObject.GetComponent<Gato>().jugable = false;
            }
            GetComponent<AudioSource>().Play();
            nota.gameObject.transform.Translate(0,0,-0.30f);
            completado = true;
            puerta.GetComponent<Puerta>().setJ2(true);
            puerta.GetComponent<Puerta>().Desbloqueo();
            Destroy(this);
    }
    public Boolean c(){
        return completado;
    }
}
 