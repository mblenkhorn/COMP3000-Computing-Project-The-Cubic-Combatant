using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoinManager : MonoBehaviour, IManager
{
    public RedCoin redCoin;

    public void setValue(int theValue)
    {
        redCoin.setValue(theValue);
    }
}
