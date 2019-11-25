using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighscoreController : MonoBehaviour
{
    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
