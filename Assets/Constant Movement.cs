using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float velocity = 5f;
    public Vector3 direction;
    // Start is called before the first frame update 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = new Vector3(5f, 0f, 0f) * Time.fixedDeltaTime + gameObject.transform.position;
        gameObject.transform.position = direction * velocity * Time.deltaTime + gameObject.transform.position;
    }
}
