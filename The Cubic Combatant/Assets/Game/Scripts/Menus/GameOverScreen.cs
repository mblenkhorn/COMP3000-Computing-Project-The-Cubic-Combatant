using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour, IMenu, IScreen, IStart
{
   public void open(GameObject menuToOpen)
   {
       MusicManager.instance.PlaySound(MusicManager.instance.gameOverMusic);
       MusicManager.instance.music.Stop();
       menuToOpen.SetActive(true);
   }

    public void close(GameObject menuToClose)
    {
        menuToClose.SetActive(false);
        GoBack();
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
