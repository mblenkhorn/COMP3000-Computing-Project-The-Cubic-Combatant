using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public float moveSpeed;

    private Transform currentPoint;

    public Transform[] patrolPoints;

    public int patrolSelection;

    private void Start()
    {
        GetFirstPatrolPoint();
    }

    private void GetFirstPatrolPoint()
    {
        currentPoint = patrolPoints[patrolSelection];
    }

    private void Update()
    {
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);

        if(enemy.transform.position == currentPoint.position)
        {
            patrolSelection++;

            if(patrolSelection == patrolPoints.Length)
            {
                ResetPatrolSelection();
            }

            currentPoint = patrolPoints[patrolSelection];
        }
    }

    private void ResetPatrolSelection()
    {
        patrolSelection = 0;
    }


}