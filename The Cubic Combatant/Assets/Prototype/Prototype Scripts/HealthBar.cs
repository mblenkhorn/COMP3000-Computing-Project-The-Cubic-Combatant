using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBarSlider;

    private float currentHealth;

    private float fillSpeed = 0.75f;

    private Color satisHealthColour = Color.green;
    private Color halfHealthColour = Color.yellow;
    private Color nearDeathColour = Color.red;

    public Image fillColour;


    private void Start()
    {
        DecrementHealth(7f);
    }

    private void Update()
    {
        if(healthBarSlider.value > currentHealth)
        {
            healthBarSlider.value -= fillSpeed * Time.deltaTime;
        }

        if (healthBarSlider.value <= 6f && healthBarSlider.value >= 4f)
        {
            fillColour.color = satisHealthColour;
        }
        else if (healthBarSlider.value <= 4f && healthBarSlider.value >= 2f)
        {
            fillColour.color = halfHealthColour;
        }
        else if(healthBarSlider.value <= 2f)
        {
            fillColour.color = nearDeathColour;
        }
    }


    public void DecrementHealth(float newHealth)
    {
        currentHealth = healthBarSlider.value - newHealth;
        Debug.Log(currentHealth);
    }



}
