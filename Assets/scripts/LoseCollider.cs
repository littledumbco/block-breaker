using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    // Giving the script access to LevelManager so that I can make sure that LoadLevel is available for collision
    public LevelManager levelManager;

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");

        // utilising levelManager to load the level 'Win' when the ball hits the box off-screen
        levelManager.LoadLevel("Finish");
    }
}
