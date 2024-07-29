using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public float radius = 5.0f;
    public int frameCount = 5;
    int tick = 0;
    public int maxCount = 50;
    
    /*Vector3[] noktalar;
    Vector3[] noktalar2 = new Vector3[5];
    Vector3[] noktalar1 = new Vector3[50];*/
    private List<Vector3> noktalar =new();
    //sabit hýzla gitsin
    //10 nokta giderse 11. noktada 1. noktayý silsin
    void Awake()
    {
        //gameObject.transform.position = new Vector3(0, 0, 0);
    }
   
    void OnDrawGizmos()
    {
        // Display the explosion radius when selected   
        Gizmos.color = new Color(1, 1, 0, 0.75F);
        foreach(var item in noktalar)
        Gizmos.DrawSphere(item, radius);        
    }
    void FixedUpdate()
    {
        tick = ++tick % frameCount;
        if (tick != 0)
        return;
        noktalar.Add(transform.position);

        if (noktalar.Count > maxCount)
        {
            noktalar.RemoveAt(0);
        }
    }
    void Update()
    {
        //(Debug.Log(new Vector3(5f, 0f, 0f));
    }
}
