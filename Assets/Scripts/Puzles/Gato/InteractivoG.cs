using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class InteractivoG : MonoBehaviour
{
    private GameObject O;
    public virtual void Interact()
    {
        O = Instantiate(O, transform.position, Quaternion.identity);
    }
}
