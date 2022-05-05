using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    private Checkpoint currentCheckPoint;

    public Player player;

    public PlayerSpawner spawn;

    public Checkpoint getCheckPoint()
    {
        return currentCheckPoint;
    }

    public void setCheckPoint()
    {
        spawn.currentPoint = currentCheckPoint;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            setCheckPoint();
        }
    }
}
