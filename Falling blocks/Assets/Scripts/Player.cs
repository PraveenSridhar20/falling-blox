using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=10f;
    public float screenWidth;
    public event System.Action OnPlayerDeath;
    public float playerWidth;
    public float coinCounter=0;
    // Start is called before the first frame update
    void Start()
    {
        playerWidth=transform.localScale.x/2;        
        screenWidth=Camera.main.aspect*Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 input=new Vector2(Input.GetAxisRaw("Horizontal"),0);
       Vector2 pos=input.normalized*Time.deltaTime*speed;
       transform.Translate(pos);
       if (transform.position.x<-screenWidth-playerWidth)
       {
         transform.position=new Vector2(screenWidth,transform.position.y);
       }
       if (transform.position.x>screenWidth+playerWidth)
       {
         transform.position=new Vector2(-screenWidth,transform.position.y);
       }
       
     }
     void OnTriggerEnter(Collider triggerCollider)
       {
         if (triggerCollider.tag=="Block")
         {
          if(OnPlayerDeath!=null){
            OnPlayerDeath();
          }
          Destroy (gameObject);
         }
         if (triggerCollider.tag=="Coin")
         {
          coinCounter+=1; 
          Destroy(triggerCollider.gameObject);
         }
          
       } 
}
