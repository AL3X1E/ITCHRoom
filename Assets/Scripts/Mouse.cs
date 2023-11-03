using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public float sX;
    public float sY;
    public Transform or;
    
    float xR;
    float yR;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sY;
        yR += mouseX;
        xR -= mouseY;
        xR = Mathf.Clamp(xR, -90f, 90f);
        transform.rotation = Quaternion.Euler(xR, yR, 0);
        or.rotation = Quaternion.Euler(0, yR, 0);
    }
}
