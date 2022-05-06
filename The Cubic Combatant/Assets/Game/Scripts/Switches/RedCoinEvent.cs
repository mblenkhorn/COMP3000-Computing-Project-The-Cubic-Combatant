using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoinEvent : SwitchEvent
{
    public GameObject redCoins;

    public RedCoin coin;

    public StarSpawner spawner;

    public GameObject barrier;
    
    public override void beginEvent()
    {
        redCoins.SetActive(true);
    }

    private void Update()
    {
        removeBarrier();
    }

    public void removeBarrier()
    {
        if(coin.getValue() == coin.getMaxCoins())
        {
            Debug.Log("DESTROY");
            Destroy(barrier);
            spawner.Spawn();
        }
    }
}
