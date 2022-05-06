using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCoinManager : MonoBehaviour, IManager
{

    [SerializeField]
    private BigCoin coin;

    public void setValue(int theValue)
    {
        coin.setValue(1);
        coin.setCoinCounter();
    }
}
