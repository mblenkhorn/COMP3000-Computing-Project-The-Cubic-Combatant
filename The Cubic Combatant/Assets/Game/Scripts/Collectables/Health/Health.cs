using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float health;

    [SerializeField]
    private float maxHealth;

    private void Start()
    {
        health = maxHealth;
    }

    public float getHealth()
    {
        return health;
    }

    public void setHealth(float inHealth)
    {
        health += inHealth;

        if(health > maxHealth)
        {
            health = maxHealth;
        }


        Debug.Log(health);
    }

    public float getMaxHealth()
    {
        return maxHealth;
    }
}
