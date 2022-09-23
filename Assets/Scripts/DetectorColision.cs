using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    [SerializeField]
    Material ParedPorDefecto;

    [SerializeField]
    Material ParedTocada;

    bool paredRoja = false;


    float timepoenRojo = 5f;
    private void Update()
    {
        if (paredRoja == true)
        {
            timepoenRojo = timepoenRojo - Time.deltaTime;
            if (timepoenRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = ParedPorDefecto;
                paredRoja = false;
                timepoenRojo = 5f;
            }
                

        }
            

    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        gameObject.GetComponent<MeshRenderer>().material = ParedTocada;
        paredRoja = true;


    }
}