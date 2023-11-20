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

    // Update is called once per frame
    void Update()
    {
     Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);
     RaycastHit hit;
     if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance)) {
        Debug.Log(hit.transform.name); 
     }
    }
}
