using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField]
    private PlayerSpawner spawn;

    [SerializeField]
    private Life life;

    [SerializeField]
    private LifeView view;

    [SerializeField]
    private HealthDisplay health;

    [SerializeField]
    private Player player;

    [SerializeField]
    private Health healthValue;

    [SerializeField]
    private GameOverScreen screen;

    [SerializeField]
    private GameObject gameOverScreen;

    public void Kill()
    {
        FXManager.instance.PlaySound(FXManager.instance.dieSound);
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
