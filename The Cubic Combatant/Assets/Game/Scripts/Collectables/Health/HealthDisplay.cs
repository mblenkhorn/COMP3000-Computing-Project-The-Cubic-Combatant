using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour, IDisplay
{

    public Slider healthBar;
    public Health health;

    public HealthColourDisplay healthDisplay;

    // Update is called once per frame
    void Update()
    {
        Display();
    }

    public void Display()
    {
        healthDisplay.Display();
    }
}
