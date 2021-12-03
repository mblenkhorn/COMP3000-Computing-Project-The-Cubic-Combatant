using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    private int requiredObjects = 2;
    public CollectableManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && requiredObjects == manager.getCollectable())
        {
            Debug.Log("You've finished the Level!");
        }
        else
        {
            Debug.Log("Not enough objects collected!");
        }
    }

}
