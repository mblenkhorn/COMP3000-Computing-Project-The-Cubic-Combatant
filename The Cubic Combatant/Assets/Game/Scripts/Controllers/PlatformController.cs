using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : NPCController
{
    // Start is called before the first frame update
    void Start()
    {
        GetFirstPatrolPoint();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move()
    {
       NPC.transform.position = Vector3.MoveTowards(NPC.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);

        if (NPC.transform.position == currentPoint.position)
        {
            wayPointIndex++;

            if (wayPointIndex == wayPoints.Length)
            {
                resetPatrolSelection();
            }

            currentPoint = wayPoints[wayPointIndex];
        }
    }

    public override void GetFirstPatrolPoint()
    {
        currentPoint = wayPoints[wayPointIndex];
    }

    public override void resetPatrolSelection()
    {
        wayPointIndex = 0;
    }
}
