using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoinPickup : Pickup
{
    [SerializeField]
    private RedCoinManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }

    public override void Collect()
    {
        FXManager.instance.PlaySound(FXManager.instance.collectSound);
        manager.setValue(1);
        gameObject.SetActive(false);
    }
}
