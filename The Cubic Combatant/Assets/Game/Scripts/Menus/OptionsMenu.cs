using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour, IMenu
{
    public void open(GameObject menuToOpen)
    {
        menuToOpen.SetActive(true);
    }

    public void close(GameObject menuToClose)
    {
        menuToClose.SetActive(false);
    }
}
