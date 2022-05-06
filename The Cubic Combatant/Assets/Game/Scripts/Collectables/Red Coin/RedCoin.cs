using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour, IItem
{
    [SerializeField]
    private int redCoinValue;

    [SerializeField]
    private int maxRedCoins;


    public int getValue()
    {
        return redCoinValue;
    }

    public int getMaxCoins()
    {
        return maxRedCoins;
    }

    public void setValue(int inValue)
    {
        redCoinValue += inValue;
        Debug.Log(redCoinValue);
    }
}
