using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void HighscoreMenu()
    {
        SceneManager.LoadScene("HighscoreScene");
    }

   public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void QuitGame()
    {
        QuitGame();
    }

    public void MusicButton()
    {

    }
}
