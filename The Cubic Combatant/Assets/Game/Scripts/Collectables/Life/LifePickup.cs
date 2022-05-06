using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickup : Pickup
{
    [SerializeField]
    private LifeManager manager;

    [SerializeField]
    private LifeView view;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }

    public override void Collect()
    {
        manager.setValue(1);
        view.Display();
        Destroy(gameObject);
    }
}
