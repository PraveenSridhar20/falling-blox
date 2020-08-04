using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Text secondsSurvived;
    public Text coinCount;
    bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
      FindObjectOfType<Player>().OnPlayerDeath+=OnGameOver;
    }

    // Update is called once per frame
    void Update()
    {
          if(gameOver)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
    }
    void OnGameOver()
    {
        gameOverScreen.SetActive(true);
        secondsSurvived.text=Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString()+" Seconds";
        coinCount.text="\n"+(FindObjectOfType<Player>().coinCounter).ToString()+" Coins";
        gameOver=true;
    }
}
