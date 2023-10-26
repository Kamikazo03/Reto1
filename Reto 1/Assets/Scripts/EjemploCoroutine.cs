using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploCoroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("cambiarColor");
    }

    IEnumerable cambiarColor()
    {
        yield return new WaitForSeconds(1f);
        GetComponent<Renderer>().material.color = UnityEngine.Color.red;
        yield return new WaitForSeconds(1.5f);
        GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
    }
}
