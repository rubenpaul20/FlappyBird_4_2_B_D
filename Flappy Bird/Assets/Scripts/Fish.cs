using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    //this is the variable which will control the amount of force
    [SerializeField]
    private float force = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //use spacebar to make our fish jump
        //we are going to use local variable
        //the button jump represents the space key
        bool pressedJumpButton = Input.GetButtonDown("Jump");

        //if pressedJumpButton is true which means we are pressing space
        //make fish jump
        //if the pressedJumpButton = true
        if(pressedJumpButton)
        {
            Debug.Log("You pressed the space button");

            //find the rigidbody of the fish
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            //set the fish velocity to zero
            rigidbody.velocity = Vector3.zero;
            //add force to our fish to make it jump
            //Vector3(0,1,0) * force(1000)
            rigidbody.AddForce(Vector3.up * force);
        }
    }
}
