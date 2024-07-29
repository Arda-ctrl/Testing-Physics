using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Color currentColor;
    public byte hitPoint;
    int count=4;
    int count2 = 4;
    public int divider=5;
    MeshRenderer mr;
   


    void Awake()
    {


        //mr = gameObject.GetComponent<MeshRenderer>();
        //mr.material.color = Color.white;
        //gameObject.GetComponent<MeshFilter>().mesh = gameObject.createPrimitive(PrimitiveType.Sphere);

       
    
    }
  


    /*void BlackToWhite()
    {

        if (Color.black == mr.material.color)
        {
            mr.material.color = Color.white;
        }
        else
        {
            mr.material.color = Color.black;
        }

    }*/
    

    // Update is called once per frame
    void Update()
    {
        /*count++;
        if (count % divider == 0)
        {
            Debug.Log("current : " + count);
            BlackToWhite();
        }*/


    }

    public void YokEt(GameObject nesne)
    {
        Destroy(nesne);
    }
    void OnCollisionEnter(Collision collision)
    {
        //BlackToWhite();
        if (collision.gameObject.CompareTag("MaviTop"))
        {
            // Mavi topa çarpýldýðýnda count'u 2 azalt
            count -= 1;
        }
        if (collision.gameObject.CompareTag("KirmiziTop"))
        {
            // Kýrmýzý topa çarpýldýðýnda count'u 3 azalt
            count2 -= 2;
        }
       
        Debug.Log("Count sayisi " + count);
        if(count == 0 ) 
        {
            YokEt(gameObject);
        }
        if (count2 == 0)
        {
            YokEt(gameObject);
        }


    }


}
