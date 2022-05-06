using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActor : MonoBehaviour
{
    public GameObject playerActor;
    public GameObject groundActor;

    public GameObject mainMenu;

    public void enableActor()
    {
        if (mainMenu.activeSelf)
        {
            playerActor.SetActive(true);
            groundActor.SetActive(true);
        }
    }

    public void disableActor()
    {
        if (!mainMenu.activeSelf)
        {
            playerActor.SetActive(false);
            groundActor.SetActive(false);
        }
    }
}
