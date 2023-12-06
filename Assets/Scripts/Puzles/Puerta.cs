using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject Juego1, Juego2;
    private Boolean j1,j2;
    public virtual void Desbloqueo()
    {
    if(j1 == true && j2 == true){
        gameObject.transform.Rotate(0, -135, 0);
        GetComponent<AudioSource>().Play();
        Destroy(this);
        }
    }
    public virtual void setJ1(Boolean j){
        j1 = j;
    }
    public virtual void setJ2(Boolean j){
        j2 = j;
    }
}
