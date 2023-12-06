using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gato : MonoBehaviour
{
    public Boolean jugable;
    private int jugador;

    public virtual void block(){
        jugable = false;

    }
    public virtual void reset(){
        if(jugable == false){
            jugable = true;
            gameObject.transform.Rotate(0, -180, 0);
            gameObject.transform.Translate(-0.5f, 0, 0);
        }
    }
    public virtual void X(){
        jugador = 1;
    }
    public int GetJugador(){
        return jugador;
    }
}
