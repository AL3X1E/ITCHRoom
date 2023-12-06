using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField, Tooltip("Tiempo")] private float timerTime;
    private int minutes, seconds;
    private float salir;
    public GameObject sol;
    private void Update()
    {
        timerTime -= Time.deltaTime;
        if(timerTime < 0) timerTime = 0;

        minutes = (int)(timerTime / 60f);
        seconds = (int)(timerTime - minutes * 60f);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if(timerTime <= 0){
            timerText.text = string.Format("Has perdido...");
            salir += Time.deltaTime;
            if(salir >= 5){
            Debug.Log("Perdiste");
            Destroy(this);
            Application.Quit();
            }
            }
        }
    public virtual void Detener(){
        timerText.text = string.Format("");
        Destroy(this);
    }
}