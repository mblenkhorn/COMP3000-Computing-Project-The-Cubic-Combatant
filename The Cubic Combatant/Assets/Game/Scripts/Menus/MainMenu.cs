using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour, IMenu, IStart, IQuit
{
    public void open(GameObject menuToOpen)
    {
        FXManager.instance.PlaySound(FXManager.instance.confirmSelection);
        menuToOpen.SetActive(true);
    }

    public void close(GameObject menuToClose)
    {
        FXManager.instance.PlaySound(FXManager.instance.confirmSelection);
        menuToClose.SetActive(false);
    }

    public void StartGame()
    {
        FXManager.instance.PlaySound(FXManager.instance.confirmSelection);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        FXManager.instance.PlaySound(FXManager.instance.confirmSelection);
        Debug.Log("Game has Exited");
        Application.Quit();
    }
}
