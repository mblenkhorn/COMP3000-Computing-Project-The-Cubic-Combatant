using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Test");
    }

    public void CloseMenu()
    {
        Application.Quit();
        Debug.Log("Exited Game");
    }
}