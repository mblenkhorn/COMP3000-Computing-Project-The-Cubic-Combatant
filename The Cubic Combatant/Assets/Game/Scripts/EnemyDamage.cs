using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public HealthManager manager;

    public bool isDamaged;

    public Health health;

    public KillPlayer playerDie;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isDamaged)
        {
            FXManager.instance.PlaySound(FXManager.instance.hurtSound);
            manager.setValue(-2f);
            isDamaged = true;
            StartCoroutine(WaitForDamage());
            isDamaged = false;
        }

        if(health.getHealth() == 0)
        {
            playerDie.Kill();
        }
    }

    IEnumerator WaitForDamage()
    {
        yield return new WaitForSeconds(2f);
    }
}
