using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinView : MonoBehaviour, IView
{
    public TMP_Text coinText;

    public Coin coin;

    public void Display()
    {
        coinText.text = coin.getValue().ToString();
    }
}
