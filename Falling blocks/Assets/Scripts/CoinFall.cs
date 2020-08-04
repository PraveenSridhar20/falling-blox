using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFall : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(Vector2.down*speed*Time.deltaTime);    
      if(transform.position.y<-Camera.main.orthographicSize-transform.localScale.y)
       Destroy(gameObject);
    }
    
}
