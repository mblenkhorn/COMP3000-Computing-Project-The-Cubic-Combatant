using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour, IMenu, IScreen
{
    public void open(GameObject menuToOpen)
    {
        menuToOpen.SetActive(true);
    }

    public void close(GameObject menuToClose)
    {
        menuToClose.SetActive(true);
        GoBack();
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
}
