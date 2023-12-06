using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Interactivo : MonoBehaviour
{
        private GameObject m, tub, j;
    public virtual void Interact()
    {
        if(gameObject.CompareTag("Salida") == true){
        Application.Quit();
        }
        if(gameObject.CompareTag("Tubos") == true){
        gameObject.transform.Rotate(0, 90, 0);
        Debug.Log("Tubo Falso");
        }
        if(gameObject.CompareTag("Tuberia") == true){
        gameObject.transform.Rotate(0, 90, 0);
        gameObject.GetComponent<Contador>().Suma();
        tub = GameObject.Find("Tuberia");
        tub.gameObject.GetComponent<Tuberias>().Comprobacion();
        Debug.Log("Tubo Verdadero");
        }
        if(gameObject.CompareTag("Tuberia2") == true){
        gameObject.transform.Rotate(0, 90, 0);
        gameObject.GetComponent<Contador2>().Suma();
        tub = GameObject.Find("Tuberia");
        tub.gameObject.GetComponent<Tuberias>().Comprobacion();
        Debug.Log("Tubo Verdadero");
        }
        if(gameObject.CompareTag("Azul") == true){
        gameObject.GetComponent<Azul>().blue();
        Debug.Log("Azul");
        }
        if(gameObject.CompareTag("Verde") == true){
        gameObject.GetComponent<Verde>().green();
        Debug.Log("Verde");
        }
        if(gameObject.CompareTag("Rojo") == true){
        gameObject.GetComponent<Rojo>().red();
        Debug.Log("Rojo");
        }
        if(gameObject.CompareTag("Gato") == true && gameObject.GetComponent<Gato>().jugable == true){
        j = GameObject.Find("Gato");
        gameObject.transform.Rotate(0, -180, 0);
        gameObject.transform.Translate(-0.5f, 0, 0);
        gameObject.GetComponent<Gato>().block();
        gameObject.GetComponent<Gato>().X();
        j.GetComponent<Tablero>().Comprobar();
        Debug.Log("Gato");
        m = GameObject.FindGameObjectWithTag("GReset");
        m.gameObject.GetComponent<Reset>().Machine();
        }
        if(gameObject.CompareTag("GReset")){
        gameObject.GetComponent<Reset>().Restart();
        Debug.Log("Reiniciar Gato");
        } 
    } 
}

