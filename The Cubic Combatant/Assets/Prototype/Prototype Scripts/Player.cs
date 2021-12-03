using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerBody; //this is the Player's Rigidbody
    private bool isJumped; //checks if the Player has jumped or not
    public float moveSpeed = 5f; //speed of the Player
    public float jumpHeight = 2f; //jump height of the Player

    private Vector3 inputVector; //this is a vector to where the Player move to

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>(); //gets the rigidbody component
    }

    // Update is called once per frame
    void Update()
    {
        //creates a new vector3 (input horizontal as x * moveSpeed, playerbody.velocity.y as y, input vertical as z * moveSpeed) and stores it in inputVector
        //Input.GetAxis("Horizontal") * moveSpeed changes the x position
        //Input.GetAxis("Vertical") * moveSpeed changes the z position  
        inputVector = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, playerBody.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
        //allows the Player to look horizontally or vertically
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

        if (Input.GetButtonDown("Jump"))
        {
            isJumped = true;
        }

    }

    private Vector3 getInputVector()
    {
        return inputVector;
    }

    private void Jump()
    {
        if (isJumped)
        {
            playerBody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse); //moves the player upwards and adds a force to the jump
            isJumped = false;
        }
    }

    private void MovePlayer()
    {
        playerBody.velocity = getInputVector(); //store inputVector in the playerBody.velocity (allows the Player to move horizontally or vertically) 
    }

    private void FixedUpdate()
    {
        //playerBody.velocity = inputVector; //store inputVector in the playerBody.velocity (allows the Player to move horizontally or vertically) 
        MovePlayer();
        Jump();
    }
}