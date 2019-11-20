using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    //public GameObject gameOverText;
    public float scrollSpeed = -1.5f;

    public bool gameOver = false;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void PlayerDied()
    {
        gameOver = true;
    }
}

