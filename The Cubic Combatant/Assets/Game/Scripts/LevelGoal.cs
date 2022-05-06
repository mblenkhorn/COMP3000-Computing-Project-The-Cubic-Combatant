using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGoal : MonoBehaviour
{
    private Star starData;

    [SerializeField]
    public WinScreen winScreenPanel;

    [SerializeField]
    public GameObject winPanel;

    private void Start()
    {
        starData = FindObjectOfType<Star>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(starData.getValue() == starData.getMaxStars())
        {
            winScreenPanel.open(winPanel);
        }
        else
        {
            Debug.Log("You don't have enough Stars");
        }
    }
}
