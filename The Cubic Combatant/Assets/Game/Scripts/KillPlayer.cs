using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public PlayerSpawner spawn;
    public Life life;
    public LifeView view;
    public HealthDisplay health;
    public Player player;

    public Health healthValue;

    [SerializeField]
    public GameOverScreen screen;

    [SerializeField]
    public GameObject gameOverScreen;

    public void Kill()
    {
        life.setValue(-1);
        health.healthBar.value = 0f;
        view.Display();
        health.healthBar.value = 8f;
        Debug.Log(health.healthBar.value);
        spawn.Spawn();
        healthValue.setHealth(8f);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && life.getValue() != 0)
        {
            Kill();
        }
        else
        {
            screen.open(gameOverScreen);
        }
    }

}
