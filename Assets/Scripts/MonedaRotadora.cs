using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaRotadora : MonoBehaviour
{


    [SerializeField]
    float rotacionX = 10f;

    void Update()
    {        //rotar la moneda en su eje X (x,y,z)
        transform.Rotate(rotacionX * Time.deltaTime, 0f, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        // collision.gameObject.SetActive(false); 


    }
}
