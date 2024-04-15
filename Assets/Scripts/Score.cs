using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    public float timer = 0.0f;
    public float timerRate = 1.0f;

    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0); //loads an integer value using a string key
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore); //sets an integer value using a string key
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * timerRate;
        //time.deltatime is how many seconds are passing between frames. So if it's called once per frame in Update, it'll make a live timer
        if (timer >= 1.0)
        {
            score++;
            scoreDisplay.text = "Score: " + score.ToString();
            timer = 0.0f;
            if (score > highScore) //new high score
            {
                highScore = score;
            }
        }    
    }
}
