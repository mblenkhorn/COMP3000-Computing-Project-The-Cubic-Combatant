using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IItem
{
    private int coinValue;

    public int getValue()
    {
        return coinValue;
    }

    public void setValue(int valueToSet)
    {
        coinValue += valueToSet;
        Debug.Log(coinValue);
    }

}
