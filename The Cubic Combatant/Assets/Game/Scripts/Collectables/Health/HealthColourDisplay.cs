using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthColourDisplay : MonoBehaviour, IDisplay
{
    public Slider healthBar;

    public Health healthData;

    private float fillSpeed = 1.25f;

    private Color fullHealthColor = Color.cyan;

    private Color satisHealthColour = Color.green;
    private Color halfHealthColour = Color.yellow;
    private Color nearDeathColour = Color.red;

    public Image fillColour;


    // Start is called before the first frame update
    void Start()
    {
        fillColour.color = fullHealthColor;
    }

    // Update is called once per frame
    void Update()
    {
        Display();
    }

    public void Display()
    {
        if(healthBar.value > healthData.getHealth())
        {
            healthBar.value -= fillSpeed * Time.deltaTime;
        }

        if (healthBar.value < healthData.getHealth())
        {
            healthBar.value += fillSpeed * Time.deltaTime;
        }

        if (healthBar.value == 8.0f || healthBar.value >= 7.0f)
        {
            fillColour.color = fullHealthColor;
        }

        if (healthBar.value <= 6.5f && healthBar.value >= 5.0f)
        {
            fillColour.color = satisHealthColour;
        }
        else if (healthBar.value <= 4.5f && healthBar.value >= 3.0f)
        {
            fillColour.color = halfHealthColour;
        }
        else if (healthBar.value <= 3.0f)
        {
            fillColour.color = nearDeathColour;
        }
    }
}
