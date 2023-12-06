using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verde : MonoBehaviour
{
    public GameObject[] verde = new GameObject[9];
    public GameObject ap;
    public int n;
    void Start()
    {
        verde[0] = GameObject.Find("V1");
        verde[1] = GameObject.Find("V2");
        verde[2] = GameObject.Find("V3");
        verde[3] = GameObject.Find("V4");
        verde[4] = GameObject.Find("V5");
        verde[5] = GameObject.Find("V6");
        verde[6] = GameObject.Find("V7");
        verde[7] = GameObject.Find("V8");
        verde[8] = GameObject.Find("V9");
        ap = GameObject.Find("Juego Final");
        n = 0;
    }
    public virtual void green(){
        if(n == 9){
            for (int i = 0; i <= 8; i++){
                verde[i].transform.Translate(0, 0.6f, 0);
            }
        n = 0;
        } else  {
            verde[n].transform.Translate(0, -0.6f, 0);
            n++;
        }
        ap.GetComponent<Abaco>().AbacoMove();
    }
}
