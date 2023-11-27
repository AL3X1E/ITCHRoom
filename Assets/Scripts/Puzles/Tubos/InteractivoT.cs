using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InteractivoT : MonoBehaviour
{
    public virtual void Interact()
    {
        gameObject.transform.Rotate(0, 90, 0);
    }
}
