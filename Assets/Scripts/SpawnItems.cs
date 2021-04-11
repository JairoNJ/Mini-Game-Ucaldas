using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    
    public Transform Player;
    public Transform pointA;
    public Transform pointB;
    

   

    void Start()
    {
        InitElements();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void InitElements()
    {
        
        Debug.Log("POINT-A: " + pointA.position);
        Debug.Log("POINT-B: " + pointB.position);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PointA")
        {
            Player.position = pointA.transform.position;
            Debug.Log("ENTRASTE");
        }
    }
}
