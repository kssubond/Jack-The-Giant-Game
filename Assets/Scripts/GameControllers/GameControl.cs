using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public Text scoreText, gameOverScoreText;
    public float scrollSpeed = 1.5f;
    public bool gameOver = false;
    public int score = 0;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private AudioSource coinClip;

    [SerializeField]
    private GameObject gameOverPanel;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        else if(instance != this)
        {
            Destroy(player);
        }
    }

    void Start()
    {
        coinClip = GetComponent<AudioSource>();
    }

    public void PlayerScored()
    {
        if (gameOver)
            return;
        score++;
        scoreText.text = "x" + score.ToString();
        coinClip.Play();
    }

    public void PlayerDied()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        gameOverScoreText.text = score.ToString();
    }
}

