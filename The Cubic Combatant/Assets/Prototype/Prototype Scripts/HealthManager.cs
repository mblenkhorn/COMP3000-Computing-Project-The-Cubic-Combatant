using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public HealthBar healthBar;


    public void SetHealth()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            healthBar.IncrementHealth(1f);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            healthBar.DecrementHealth(1f);
        }
    }

    private void Update()
    {
        SetHealth();
    }
}
