using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    // Start is called before the first frame update
    public float screenWidth1;
    public GameObject obstacles;
    
    public Vector2 timeBetweenSpawnsMinMax;
    public float nextSpawnTime;
    
    
    public Vector2 spawnSizeMinMax;
    public float spawnAngleMax;
    void Start()
    {
        screenWidth1=Camera.main.aspect*Camera.main.orthographicSize;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>nextSpawnTime)
        {
            float secondsBetweenSpawns= Mathf.Lerp(timeBetweenSpawnsMinMax.y,timeBetweenSpawnsMinMax.x,Difficulty.GetDifficultyPercent());
            nextSpawnTime=Time.time+secondsBetweenSpawns;
            float spawnSize=Random.Range(spawnSizeMinMax.x,spawnSizeMinMax.y);
            float spawnAngle=Random.Range(-spawnAngleMax,spawnAngleMax);
            Vector2 randomSpawnPos=new Vector2(Random.Range(-screenWidth1+transform.localScale.x,screenWidth1-transform.localScale.x),Camera.main.orthographicSize+transform.localScale.y);
            GameObject newBlock=(GameObject)Instantiate(obstacles,randomSpawnPos,Quaternion.Euler(Vector3.forward*spawnAngle));
            newBlock.transform.localScale=Vector2.one*spawnSize;
        }
        
       
    }
   
   

}
