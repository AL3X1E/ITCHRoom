using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private GameObject[] cuadro = new GameObject[9];
    private Vector3[] pos = new Vector3[9];
    private Vector3[] rot = new Vector3[9];
    void Start()
    {
        cuadro[0] = GameObject.Find("1x1");
        cuadro[1] = GameObject.Find("1x2");
        cuadro[2] = GameObject.Find("1x3");
        cuadro[3] = GameObject.Find("2x1");
        cuadro[4] = GameObject.Find("2x2");
        cuadro[5] = GameObject.Find("2x3");
        cuadro[6] = GameObject.Find("3x1");
        cuadro[7] = GameObject.Find("3x2");
        cuadro[8] = GameObject.Find("3x3");
        for (int i = 0; i <= 8; i++){
        pos[i] = cuadro[i].transform.position;
        rot[i] = cuadro[i].transform.eulerAngles;
        }
    }
    public virtual void Machine(){
        StartCoroutine(SpawnDelay());
    }
    public virtual void Restart()
    {
        for (int i = 0; i <= 8; i++){
        cuadro[i].transform.position = pos[i];
        cuadro[i].transform.eulerAngles = rot[i];
        cuadro[i].GetComponent<Gato>().jugable = true;
        }
    }
    private IEnumerator SpawnDelay(){
        Debug.Log("Esperando");
        yield return new WaitForSecondsRealtime(0.5f);
        Debug.Log("Turno");
        int a;
        for (int i = 0; i <= 100; i++){
        a = Random.Range(0, 9);
        if(cuadro[a].GetComponent<Gato>().jugable == true){
        cuadro[a].gameObject.GetComponent<Gato>().block();
        cuadro[a].gameObject.GetComponent<AudioSource>().Play();
        cuadro[a].gameObject.transform.Translate(-0.25f, 0, 0);
        cuadro[a].GetComponent<Gato>().jugable = false;
        i = 101;
        }
        }
    }
}