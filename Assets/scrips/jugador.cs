using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public float movimientoX;
    public float movimientoY;
    public float movimientoZ;
    public int puntaje = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoX = Input.GetAxis("Horizontal") * Time.deltaTime * 5;
        movimientoZ = Input.GetAxis("Vertical") * Time.deltaTime * 5;
        transform.Translate(movimientoX, movimientoY, movimientoZ);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0f , 8 * Time.deltaTime, 0f);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("monedas"))
        {
            puntaje++;
            Destroy(collision.gameObject);
        }
     
    }
}
