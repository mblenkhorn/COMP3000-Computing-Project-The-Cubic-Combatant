using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    public int collectableAmount = 0;
    public UI collectText;

    public void CollectObject()
    {
        collectableAmount++;
        collectText.UpdateText();
        
    }

    public int getCollectable()
    {
        return collectableAmount;
    }

    private void Start()
    {
        collectText = FindObjectOfType<UI>();
    }

}