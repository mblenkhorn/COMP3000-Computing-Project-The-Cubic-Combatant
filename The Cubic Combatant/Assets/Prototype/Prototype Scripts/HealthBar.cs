using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBarSlider;

    private float currentHealth = 8f;

    private float fillSpeed = 0.75f;

    public Color fullHealthColor;
    private Color satisHealthColour = Color.green;
    private Color halfHealthColour = Color.yellow;
    private Color nearDeathColour = Color.red;

    public Image fillColour;


    private void Start()
    {
        fillColour.color = fullHealthColor;
    }

    private void Update()
    {
        if(healthBarSlider.value > currentHealth)
        {
            healthBarSlider.value -= fillSpeed * Time.deltaTime;
        }

        if(healthBarSlider.value < currentHealth)
        {
            healthBarSlider.value += fillSpeed * Time.deltaTime;
        }

        if(healthBarSlider.value == 8f || healthBarSlider.value >= 7f)
        {
            fillColour.color = fullHealthColor;
        }

        if (healthBarSlider.value <= 6f && healthBarSlider.value >= 5f)
        {
            fillColour.color = satisHealthColour;
        }
        else if (healthBarSlider.value <= 4f && healthBarSlider.value >= 3f)
        {
            fillColour.color = halfHealthColour;
        }
        else if(healthBarSlider.value <= 3f)
        {
            fillColour.color = nearDeathColour;
        }
    }


    public void DecrementHealth(float newHealth)
    {
        currentHealth = healthBarSlider.value - newHealth;
        Debug.Log(currentHealth);
    }

    public void IncrementHealth(float newHealth)
    {
        currentHealth = healthBarSlider.value + newHealth;
        Debug.Log(currentHealth);
    }
}