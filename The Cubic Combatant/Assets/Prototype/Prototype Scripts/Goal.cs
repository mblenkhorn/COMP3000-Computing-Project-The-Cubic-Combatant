using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    private int requiredObjects = 4;
    public GameObject panel;
    public CollectableManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && requiredObjects == manager.getCollectable())
        {
            panel.SetActive(true);
        }
        else
        {
            Debug.Log("Not enough objects collected!");
        }
    }

}
