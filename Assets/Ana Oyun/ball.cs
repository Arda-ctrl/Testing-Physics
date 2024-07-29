using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{


    public float hareketHizi = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // Blo�u +x y�n�nde hareket ettir
            transform.Translate(Vector3.left * hareketHizi * Time.deltaTime);
        }

        // D tu�una bas�ld���nda
        if (Input.GetKey(KeyCode.D))
        {
            // Blo�u -x y�n�nde hareket ettir
            transform.Translate(Vector3.right * hareketHizi * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.W))
        {
            
            transform.Translate(Vector3.up * hareketHizi * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            // Blo�u -x y�n�nde hareket ettir
            transform.Translate(Vector3.down * hareketHizi * Time.deltaTime);
        }

    }


}
