using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{

    [SerializeField]
    private HealthManager manager;


    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<HealthManager>();
    }

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
        manager.setValue(2f);
        Destroy(gameObject);
    }
}
