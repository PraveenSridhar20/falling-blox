using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
  public Vector2 speedminMax;
    public float speed1;

    // Start is called before the first frame update
    void Start()
    {
        speed1=Mathf.Lerp(speedminMax.x,speedminMax.y,Difficulty.GetDifficultyPercent());
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.down*speed1*Time.deltaTime);
       if(transform.position.y<-Camera.main.orthographicSize-transform.localScale.y)
       Destroy(gameObject);
    }
}
