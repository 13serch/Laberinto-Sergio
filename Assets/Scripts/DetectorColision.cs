using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    [SerializeField]
    Material ParedPorDefecto;

    [SerializeField]
    Material ParedTocada;
   private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        gameObject.GetComponent<MeshRenderer>().material = ParedTocada;



    }
}