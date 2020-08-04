using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public float screenWidth;
    public float spawnTime=1f;
    public float nextSpawnTime;
    public GameObject coinFall;
    // Start is called before the first frame update
    void Start()
    {
        screenWidth=Camera.main.orthographicSize*Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>nextSpawnTime)
        {
            nextSpawnTime=Time.time+spawnTime;
            Vector2 randomSpawnPos=new Vector2(Random.Range(-screenWidth+transform.localScale.x,screenWidth-transform.localScale.x),Camera.main.orthographicSize+transform.localScale.y);
            Instantiate(coinFall,randomSpawnPos,Quaternion.identity);
        }
    }
}
