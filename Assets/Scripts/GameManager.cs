using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

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
        SceneManager.LoadScene(1);
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
