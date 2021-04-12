using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject souldBlue;

    
    public Transform pointA;
    public Transform pointB;

    public float timeSpawn = 1f;
    public float repeatRater = 2f;


    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("SpawnSoulds", 2, repeatRater);
    }


    public void SpawnSoulds()
    {
        float point1 = pointA.position.x;
        float point2 = pointB.position.x;
        Vector3 spawnPosition = new Vector3(Random.Range(point1, point2), 0, 0);
        Instantiate(souldBlue, spawnPosition, Quaternion.identity);
    }
    

 
}
