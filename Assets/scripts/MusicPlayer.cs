using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    // Creating a static variable with the name 'instance' - that instance of MusicPlayer is set to null
    // aka, it does not exist.
    static MusicPlayer instance = null;

    private void Awake()
    {
        // Moved the IF statement so that the duplication checker is ran before Start
        // The bug here was that the duplicate would play for a fraction of a second because it was still
        // being started and then being destroyed.
        Debug.Log("Music player awake" + GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
            Debug.Log("Duplicate destroyed.");

            // OR if it doesn't exist for some strange reason, then actually create one to exist.
        }
        else
        {
            // 'this' is used to 'claim' the instance and say yes, this is the global version of 'instance'
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {

        // Then using the 'instance' variable to check the condition, so if the MusicPlayer already exists
        // (as it's been created by the Start scene), then do not create a new one when jumping to another
        // scene
        Debug.Log("Music player start" + GetInstanceID());


        // gameObject with a small 'g' refers to the object the script is attached to
        GameObject.DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
