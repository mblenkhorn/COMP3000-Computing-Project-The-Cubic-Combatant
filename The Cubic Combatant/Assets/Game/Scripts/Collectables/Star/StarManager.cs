using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour, IManager
{
    [SerializeField]
    private Star star;

    public void setValue(int theValue)
    {
        star.setValue(theValue);
    }
}
