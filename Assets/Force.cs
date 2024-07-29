using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public float mass;
    public Vector3 force;
    public Vector3 velocity;
    Vector3 acceleratýon;
    //public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        if (mass == 0)
            mass = 0.1f;
        acceleratýon=force/mass;
        //iki top var bi tanesinin vector3üne baðlý oalrak diðeri bilardo gibi acceleration yapacak

    }

    // Update is called once per frame
    void Update()
    {
       
        velocity += acceleratýon * Time.deltaTime;
        

        transform.position += velocity * Time.deltaTime;
    }
}
