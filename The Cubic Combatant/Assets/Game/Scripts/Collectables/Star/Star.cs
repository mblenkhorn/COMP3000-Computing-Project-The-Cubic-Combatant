using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour, IItem
{
    private int starValue;

    [SerializeField]
    private int maxStars;


    public int getValue()
    {
        return starValue;
    }

    public int getMaxStars()
    {
        return maxStars;
    }

    public void setValue(int valueToSet)
    {
        starValue += valueToSet;
        Debug.Log(starValue);
    }
}
