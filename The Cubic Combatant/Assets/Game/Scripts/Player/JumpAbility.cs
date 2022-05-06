using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAbility : Ability
{
    public Protagonist protagonist;

    public float jumpHeight = 10f;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    public bool isGrounded;


    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround())
        {
            performAbility();
        }
    }

    public override void performAbility()
    {
        protagonist.getPlayerBody().AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
    }

    public bool isOnGround()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
        return isGrounded;
    }
}
