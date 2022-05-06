using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour, ISpawn
{
    public Player player;
    public Checkpoint currentPoint;

    public void Spawn()
    {
        player.transform.position = currentPoint.getCheckPoint().transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Spawn();
        }
    }
}
