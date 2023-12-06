using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Azul : MonoBehaviour
{
    public GameObject[] azul = new GameObject[9];
    public GameObject ap;
    public int n;
    void Start()
    {
        azul[0] = GameObject.Find("A1");
        azul[1] = GameObject.Find("A2");
        azul[2] = GameObject.Find("A3");
        azul[3] = GameObject.Find("A4");
        azul[4] = GameObject.Find("A5");
        azul[5] = GameObject.Find("A6");
        azul[6] = GameObject.Find("A7");
        azul[7] = GameObject.Find("A8");
        azul[8] = GameObject.Find("A9");
        ap = GameObject.Find("Juego Final");
        n = 0;
    }
    public virtual void blue(){
        if(n == 9){
            for (int i = 0; i <= 8; i++){
                azul[i].transform.Translate(0, 0.6f, 0);
            }
        n = 0;
        } else  {
            azul[n].transform.Translate(0, -0.6f, 0);
            n++;
        }
        ap.GetComponent<Abaco>().AbacoMove();
    }
}
