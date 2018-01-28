using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // enabling the ability for the Ball script to access the paddle script
    private Paddle paddle;

    // This has to be added as in the update function the ball is consistently being told
    // to stick to the paddle. The variable below is to check if the game has started or
    // not.
    private bool hasStarted = false;

    // Setting up a private variable to capture the distance between the ball and the paddle
    private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {

        paddle = GameObject.FindObjectOfType<Paddle>();

        // By getting the position of the ball and subtracting that by the position of the paddle
        // So in this scenario, the ball might be y 0.5 and the paddle might be y 0 - so it takes away 0.5
        // which puts the ball at 0.
        paddleToBallVector = this.transform.position - paddle.transform.position;
	}

    // Update is called once per frame
    void Update() {

        // So this is the hasStarted variable implemented to handle that ball stickyness to paddle issue!
        // IF the game hasn't started then lock the ball to the paddle.
        if (!hasStarted)
        {
            // So this takes the ball's current position, looks at the paddle's position and then adds the distance
            // missing. So it checks the ball and the paddle every frame and then just removes the distance factor
            // by applying the paddleToBallVector.
            this.transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                print("Mouse clicked, launch ball!");

                // IF the game has started, then let the ball launch.
                hasStarted = true;
                // Had to change this up here compared to the tutorial as it had been desolved in newer version
                // of Unity. 
                GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }
        }
	}
}
