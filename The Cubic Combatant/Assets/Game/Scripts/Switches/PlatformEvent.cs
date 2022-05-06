using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformEvent : SwitchEvent
{
    public GameObject platforms;

    public override void beginEvent()
    {
        platforms.SetActive(true);
    }

}
