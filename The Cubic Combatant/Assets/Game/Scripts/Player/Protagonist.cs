using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonist : MonoBehaviour
{

    public float moveSpeed;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public float getSpeed()
    {
        return moveSpeed;
    }

    public Rigidbody getPlayerBody()
    {
        return rb;
    }
}