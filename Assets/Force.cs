using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public float mass;
    public Vector3 force;
    public Vector3 velocity;
    Vector3 accelerat�on;
    //public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        if (mass == 0)
            mass = 0.1f;
        accelerat�on=force/mass;
        //iki top var bi tanesinin vector3�ne ba�l� oalrak di�eri bilardo gibi acceleration yapacak

    }

    // Update is called once per frame
    void Update()
    {
       
        velocity += accelerat�on * Time.deltaTime;
        

        transform.position += velocity * Time.deltaTime;
    }
}
