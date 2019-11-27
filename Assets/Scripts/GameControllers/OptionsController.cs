using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    [SerializeField]
    private GameObject easyCheckSign, mediumCheckSign, hardChecksign;
    [SerializeField]
    private AudioSource clickSound;

    void Start()
    {
        clickSound = GetComponent<AudioSource>();
    }
    public void EasyLevel()
    {
        easyCheckSign.SetActive(true);
        clickSound.Play();
        SceneManager.LoadScene("GameScene");
        ScrollingObject.speed = 0.9f;
        CloudPool.spawnRate = 2.15f;
    }

    public void MediumLevel()
    {
        mediumCheckSign.SetActive(true);
        clickSound.Play();
        SceneManager.LoadScene("GameScene");
        ScrollingObject.speed = 1.7f;
        CloudPool.spawnRate = 1.4f;
    }

    public void HardLevel()
    {
        hardChecksign.SetActive(true);
        clickSound.Play();
        SceneManager.LoadScene("GameScene");
        ScrollingObject.speed = 2.5f;
        CloudPool.spawnRate = 0.8f;
    }

    public void GoBackToMainMenu()
    {
        clickSound.Play();
        SceneManager.LoadScene("StartMenu");
    }
}
