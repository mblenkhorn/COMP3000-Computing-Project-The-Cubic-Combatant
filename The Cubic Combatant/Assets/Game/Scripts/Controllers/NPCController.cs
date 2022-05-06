using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCController : MonoBehaviour
{
    [SerializeField]
    protected Transform[] wayPoints;

    [SerializeField]
    protected Transform currentPoint;

    [SerializeField]
    protected int wayPointIndex;

    [SerializeField]
    protected float moveSpeed;

    [SerializeField]
    protected GameObject NPC;

    public abstract void Move();

    public abstract void GetFirstPatrolPoint();

    public abstract void resetPatrolSelection();
}
