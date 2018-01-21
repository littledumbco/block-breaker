using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // creating a new vector variable called paddlePos that gives it an x position of 0.5 (left side of screen)
        // takes the y position of the paddle and the z position remains at 0.
        Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);

        // creates a new number to capture (float) called mousPosInBlocks) that takes the current x position of the
        // mouse position, divides it by the width of the Screen and then multiples it by 16. This basically converts
        // the mouse position into game units.
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        // from the paddlePos vector, we're taking the x position and applying a range to stop it from going off the
        // screen. This means that the paddle can't actually go past 0.5 on the left side and 15.5 on the right side.
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);

        // finally just applying this to the paddle itself.
        this.transform.position = paddlePos;

        

	}
}
