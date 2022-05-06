using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour, IMenu, IStart, IQuit
{
    public void open(GameObject menuToOpen)
    {
        menuToOpen.SetActive(true);
    }

    public void close(GameObject menuToClose)
    {
        menuToClose.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Game has Exited");
        Application.Quit();
    }
}
