using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour, IMenu, IQuit, IScreen
{
    public GameObject pauseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            open(pauseMenu);
        }
    }


    public void open(GameObject menuToOpen)
    {
        menuToOpen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GoBack()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void close(GameObject menuToClose)
    {
        Time.timeScale = 1f;
        menuToClose.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
