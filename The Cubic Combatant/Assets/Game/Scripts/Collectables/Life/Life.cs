using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour, IItem
{
    [SerializeField]
    private int lifeValue;

    public int getValue()
    {
        return lifeValue;
    }

    public void setValue(int valueToSet)
    {
        lifeValue += valueToSet;
        Debug.Log(lifeValue);
    }
}
