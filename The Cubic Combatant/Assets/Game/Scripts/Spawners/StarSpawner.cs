using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour, ISpawn
{
    public GameObject star;
    
    public void Spawn()
    {
        star.SetActive(true);
    }
}
