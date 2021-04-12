using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject souldsPrefab;
    public float respawnTime = 1.0f;
    public Vector2 screenBouns;

    private void Start()
    {
        screenBouns = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.y));
        StartCoroutine(souldWave());
    }

    private void SpawnEnemy()
    {
        GameObject a = Instantiate(souldsPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBouns.x  , screenBouns.x) , screenBouns.y * 2);
    }

    IEnumerator souldWave()
    {
        while(true){
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
        
    }
 
}
