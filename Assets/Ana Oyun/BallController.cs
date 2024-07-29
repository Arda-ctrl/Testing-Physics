using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb; // Topun Rigidbody bile�eni
    public float force = 10f; // Uygulanacak kuvvet miktar�

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        // Topun Rigidbody bile�enini al
    }

    void Update()
    {
        // Ekran�n dokunulan noktas�n� al
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            // Dokunma i�lemi alg�land���nda topa kuvvet uygula
            Vector3 forceDirection = (touchPosition - transform.position).normalized; // Topa uygulanacak kuvvet y�n�
            rb.AddForce(forceDirection * force, ForceMode.Impulse); // Kuvveti topa uygula
        }
    }
}
