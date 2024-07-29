using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(Mathf.Pow(3, 0.5f), 1.0f, 0f) * Time.fixedDeltaTime + gameObject.transform.position;
    }
    void Update()
    {
        Debug.Log(new Vector3(Mathf.Pow(3, 0.5f), 1.0f, 0f));
    }
    
}