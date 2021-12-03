using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public float moveSpeed;

    private Transform currentPoint;

    public Transform[] patrolPoints;

    public int patrolSelection;

    private void Start()
    {
        currentPoint = patrolPoints[patrolSelection];
        Debug.Log(currentPoint);
    }

    private void Update()
    {
        if (CollidePoint.isInArea)
        {
            MoveEnemy();
        }
    }

    public void MoveEnemy()
    {
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);

        if (enemy.transform.position == currentPoint.position)
        {
            patrolSelection++;

            //if (patrolSelection == patrolPoints.Length)
            //{
            //    patrolSelection = 0;
           // }

            //currentPoint = patrolPoints[patrolSelection];
        }
    }
}