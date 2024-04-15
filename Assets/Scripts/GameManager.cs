using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //this only works because it's static

    void Awake() //singleton
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
        //THIS IS THE PROBLEM SceneManager.LoadScene(1);
        //As you load level 0, the script on the object in that level gets an Awake call, which would cause it to load level 0. And so on forever.
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }
}