using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarView : MonoBehaviour, IView
{
    public TMP_Text starText;

    public TMP_Text maxStarText;

    public Star star;

    public void Display()
    {
        starText.text = star.getValue().ToString();
        maxStarText.text = star.getMaxStars().ToString();
    }
}
