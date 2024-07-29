using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedConstant : MonoBehaviour
{
    public float velocity = 5f;
    public Vector3 direction;
    // Start is called before the first frame update 
    void Start()
    {
        //ÖDEV : ÝVMEYÝ YENÝ BÝR CLASS OLUÞTURUP YAP
        //ÖDEV : Ayrýntýlý döküman tut (oyun için)
    }
    void FixedUpdate()
    {
        Debug.Log(Time.fixedDeltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = new Vector3(5f, 0f, 0f) * Time.fixedDeltaTime + gameObject.transform.position;
        gameObject.transform.position = direction * velocity * Time.fixedDeltaTime + gameObject.transform.position;
    }
}
