using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    private Vector3 inputVector;

    public Protagonist protagonist;


    // Update is called once per frame
    void Update()
    {
        move();
    }

    public override void move()
    {
        float x = Input.GetAxis("Horizontal") * protagonist.getSpeed();
        float y = protagonist.getPlayerBody().velocity.y;
        float z = Input.GetAxis("Vertical") * protagonist.getSpeed();
        inputVector = new Vector3(x, y, z);
    }

    private void FixedUpdate()
    {
        protagonist.getPlayerBody().velocity = inputVector;
    }
}
