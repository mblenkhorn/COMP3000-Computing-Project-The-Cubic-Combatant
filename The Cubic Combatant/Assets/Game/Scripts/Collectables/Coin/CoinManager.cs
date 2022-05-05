using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour, IManager
{
    [SerializeField]
    private Coin coin;

    public void setValue(int theValue)
    {
        coin.setValue(theValue);
    }
}
