using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHealth : MonoBehaviour
{
    public HealthManager manager;
    public Health health;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            manager.setValue(-1f);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            manager.setValue(1f);
        }
    }
}
