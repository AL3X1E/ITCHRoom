using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo : MonoBehaviour
{
    public GameObject[] rojo = new GameObject[9];
    public GameObject ap;
    public int n;
    void Start()
    {
        rojo[0] = GameObject.Find("R1");
        rojo[1] = GameObject.Find("R2");
        rojo[2] = GameObject.Find("R3");
        rojo[3] = GameObject.Find("R4");
        rojo[4] = GameObject.Find("R5");
        rojo[5] = GameObject.Find("R6");
        rojo[6] = GameObject.Find("R7");
        rojo[7] = GameObject.Find("R8");
        rojo[8] = GameObject.Find("R9");
        ap = GameObject.Find("Juego Final");
        n = 0;
    }
    public virtual void red(){
        if(n == 9){
            for (int i = 0; i <= 8; i++){
                rojo[i].transform.Translate(0, 0.6f, 0);
            }
        n = 0;
        } else  {
            rojo[n].transform.Translate(0, -0.6f, 0);
            n++;
        }
        ap.GetComponent<Abaco>().AbacoMove();
    }
}
