using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedasotrolado : MonoBehaviour
{
          float Rotacionmondedasotrolado = 100f;

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0f, Rotacionmondedasotrolado * Time.deltaTime , 0f , 0f );
    }

}

