using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador2 : MonoBehaviour
{
    private int cont = 0;
    public virtual void Suma()
    {
        if(cont >= 1){
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
