using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int health = 8;

    public float fillSpeed = 0.5f;

    public Slider healthBar;

    public void DecreaseHealth()
    {
        healthBar.value -= fillSpeed * Time.deltaTime;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            DecreaseHealth();
        }
    }
}
