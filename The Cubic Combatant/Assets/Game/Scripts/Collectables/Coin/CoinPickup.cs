using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : Pickup
{
    [SerializeField]
    private CoinManager manager;

    [SerializeField]
    private CoinView view;

    private void Start()
    {
        manager = FindObjectOfType<CoinManager>();
        view = FindObjectOfType<CoinView>();
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
        manager.setValue(50);
        view.Display();
        Destroy(gameObject);
    }
}
