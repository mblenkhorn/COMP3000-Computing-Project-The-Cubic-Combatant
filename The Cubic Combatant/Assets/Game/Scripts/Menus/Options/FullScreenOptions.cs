using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenOptions : MonoBehaviour
{
    public void setFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
