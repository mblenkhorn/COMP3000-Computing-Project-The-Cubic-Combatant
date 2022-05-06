using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigCoinView : MonoBehaviour, IView
{
    public Sprite coinAcquiredImage;

    public Image[] coinImages;

    [SerializeField]
    public BigCoin coin;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Display()
    {
        coinImages[coin.getCoinCounter()].sprite = coinAcquiredImage;
    }
}
