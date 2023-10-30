using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    public GameObject win;
    public Score elPuntaje;

    private void Update()
    {
        if(elPuntaje.Puntaje>=5)
        {
            win.SetActive(true);
        }
    }
}
