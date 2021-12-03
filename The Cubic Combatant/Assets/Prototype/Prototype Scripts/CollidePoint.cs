using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePoint : MonoBehaviour
{
    public EnemyTwo enemy;
    public static bool isInArea;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isInArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isInArea = false;
    }
}
