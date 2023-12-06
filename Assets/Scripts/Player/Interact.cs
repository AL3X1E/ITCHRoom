using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Interact : MonoBehaviour
{
    private new Transform camera;
    private GameObject cursor;
    public AudioSource click;
    public float rayDistance;
    void Start()
    {
        camera = transform.Find("Camara");
        cursor = GameObject.Find("Use");
    }
    void Update()
    {
     Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);
          RaycastHit hit;
    if(Input.GetButtonDown("Fire1")){
        if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interact"))) {
            hit.transform.GetComponent<Interactivo>().Interact();
            GetComponent<AudioSource>().Play();
            }
        }
        if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interact"))) {
        cursor.transform.localScale = new Vector3(1, 1, 1);;
        } else {
            cursor.transform.localScale = new Vector3(0,0,0);
        }
    }
}

