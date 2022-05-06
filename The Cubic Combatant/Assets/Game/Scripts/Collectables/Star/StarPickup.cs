using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickup : Pickup
{
    [SerializeField]
    private StarManager manager;

    [SerializeField]
    private StarView view;

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
        view.Display();
        Destroy(gameObject);
    }

}
