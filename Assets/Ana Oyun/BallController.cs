using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb; // Topun Rigidbody bileþeni
    public float force = 10f; // Uygulanacak kuvvet miktarý

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        // Topun Rigidbody bileþenini al
    }

    void Update()
    {
        // Ekranýn dokunulan noktasýný al
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            // Dokunma iþlemi algýlandýðýnda topa kuvvet uygula
            Vector3 forceDirection = (touchPosition - transform.position).normalized; // Topa uygulanacak kuvvet yönü
            rb.AddForce(forceDirection * force, ForceMode.Impulse); // Kuvveti topa uygula
        }
    }
}
