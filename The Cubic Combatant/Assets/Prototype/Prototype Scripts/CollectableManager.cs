using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    public int collectableAmount = 0;

    public void CollectObject()
    {
        collectableAmount++;
        Debug.Log(collectableAmount);
    }

    public int getCollectable()
    {
        return collectableAmount;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}