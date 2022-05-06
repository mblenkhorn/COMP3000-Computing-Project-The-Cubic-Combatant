using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour, IManager
{
    [SerializeField]
    private Life life;

    public void setValue(int theValue)
    {
        life.setValue(theValue);
    }
}
