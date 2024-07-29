using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleratıon : MonoBehaviour
{
    public float velocity = 0f;
    public float acceleratıon = 0.1f;
    public Vector3 direction;
    public int mass;
    //int i = 1;
    // Start is called before the first frame update
    void Start()
    {     
        //fixedda araları sabit
        //kuvvet classı yap
    }

    // Update is called once per frame
    void Update()
    {
       // if (i%5=0)
        //{
            velocity += acceleratıon * Time.deltaTime;
        //}
        
        transform.position += direction * velocity * Time.deltaTime;
        //i++;
        //StartCoroutine(WaitAndPrint(1));
    }
    /*IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Debug.Log("Coroutine waited for " + waitTime + " seconds");
    }*/
}
