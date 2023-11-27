using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private new Transform camera;
    public float rayDistance;
    void Start()
    {
        camera = transform.Find("Camara");
    }
    void Update()
    {
     Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);
     RaycastHit hit;
     if(Input.GetButtonDown("Fire1")){
        if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("InteractT"))) {
            hit.transform.GetComponent<InteractivoT>().Interact();
            Debug.Log(hit.transform.name);
            }
        }
        if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("InteractG"))) {
            hit.transform.GetComponent<InteractivoG>().Interact();
            Debug.Log(hit.transform.name);
        }
        if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("InteractA"))) {
            Debug.Log(hit.transform.name);
        }
    }
}

