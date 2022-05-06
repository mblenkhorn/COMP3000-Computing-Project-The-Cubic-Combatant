using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeView : MonoBehaviour, IView
{
    public TMP_Text lifeText;

    public Life life;

    public void Display()
    {
        lifeText.text = life.getValue().ToString();
    }
}
