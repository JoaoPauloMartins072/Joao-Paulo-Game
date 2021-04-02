using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform spawnPoint;
    
    private int rand;

    public float startTimeBtwSpawns;
    private float timeBtwSpawns;
    
    private void Start()
    {
        
        timeBtwSpawns = startTimeBtwSpawns;
        
    }
    private void Update(){
        
        
        if (timeBtwSpawns <= 0){
            Instantiate(enemies[0], spawnPoint.transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;

        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
        
    }
    
}
