using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private AudioSource clickSound;

    void Start()
    {
        clickSound = GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        clickSound.Play();
        SceneManager.LoadScene("OptionsScene");
    }

    public void QuitGame()
    {
        clickSound.Play();
        Application.Quit();
    }
}
