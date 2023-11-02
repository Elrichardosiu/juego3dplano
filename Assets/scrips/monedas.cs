using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedas : MonoBehaviour
{
          float Rotacionmondedas = -100f;

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0f, Rotacionmondedas * Time.deltaTime , 0f , 0f );
    }

}
