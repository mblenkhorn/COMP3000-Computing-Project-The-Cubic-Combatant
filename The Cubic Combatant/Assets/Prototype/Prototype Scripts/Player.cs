using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))] //if a rigidbody is missing, Unity attempts to add this type of component for you
public class Player : MonoBehaviour
{
    private Rigidbody playerRB; //this is the Player's Rigidbody
    private bool isJumped; //checks if the Player has jumped or not

    private Vector3 inputVector; //this is a vector to where the Player move to



    // Start is called before the first frame update
    void Start()
    {
        playerRB.GetComponent<Rigidbody>(); //gets the Rigidbody component
    }

    // Update is called once per frame
    void Update()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal"), playerRB.velocity.y, Input.GetAxis("Vertical"));
    }
}
