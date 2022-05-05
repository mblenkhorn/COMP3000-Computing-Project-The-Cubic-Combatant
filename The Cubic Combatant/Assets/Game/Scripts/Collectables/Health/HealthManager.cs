using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    private Health healthData;

    public void setValue(float healthToSet)
    {
        healthData.setHealth(healthToSet);
    }
}
