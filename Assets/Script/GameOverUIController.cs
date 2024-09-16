using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button mainMenuButton;
    public Button restartButton;


    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
        restartButton.onClick.AddListener(RestartButton);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Main Game");
    }
}
