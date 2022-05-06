using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSwitch : MonoBehaviour
{
    public static bool isPressed = false;

    private RedCoinEvent gameEvent;

    private void Start()
    {
        gameEvent = FindObjectOfType<RedCoinEvent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPressed)
        {
            isPressed = true;
            gameEvent.beginEvent();
            
        }
        else
        {
            Debug.Log("You've already pressed me!");
        }


    }
}
