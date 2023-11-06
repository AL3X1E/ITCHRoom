using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    //Valores de Rotacion permitida y Sensibilidad del Raton.
    float mouseSens = 200f;
    float xRotation = 0f;
    public Transform Jugador;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        //Obtener datos del movimiento del raton, en X y Y, despues girar en la rotacion correspondiente.
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Jugador.Rotate(Vector3.up * mouseX);
    }
}
