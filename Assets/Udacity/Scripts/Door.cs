using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
	bool locked = false;
	bool doorEnter = false;
	public AudioClip soundClip;

    void Update() {
        // If the door is unlocked and it is not fully raised
        // Animate the door raising up
		if (doorEnter == true && locked == true && transform.position.y >= 11.0f && transform.position.y <= 26.0f) 
		{
			transform.Translate (0, 2.0f * Time.deltaTime, 0);
		}
    }

	public void onDoorEnter()
	{
		if (locked) {
			doorEnter = true;
			AudioSource soundSource = GetComponent<AudioSource> ();
			soundSource.clip = soundClip;
			soundSource.Play ();
		}
	}

    public void Unlock()
    {
        // You'll need to set "locked" to true here
		if (Key.keyStatus) 
		{
			locked = true;
		}
    }
}
