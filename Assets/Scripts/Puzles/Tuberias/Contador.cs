using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    private int cont = 0;
    public virtual void Suma()
    {
        if(cont >= 3){
            cont = 0;
        } else { 
            cont++;
        }
        Debug.Log(cont);
    }
    public int getCont(){
        return cont;
    }
}
