using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCoin : MonoBehaviour, IItem
{
    [SerializeField]
    private int bigCoinValue;

    [SerializeField]
    private int coinCounter = -1;
    public int getValue()
    {
        return bigCoinValue;
    }

    public void setValue(int theValue)
    {
        bigCoinValue += theValue;
        Debug.Log(bigCoinValue);
        Debug.Log(coinCounter);
    }

    public int getCoinCounter()
    {
        return coinCounter;
    }

    public void setCoinCounter()
    {
        coinCounter++;
    }
}
