using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoof;
	public Door door;
	public  static bool keyStatus;

	void Update()
	{
		//Bonus: Key Animation
		transform.Rotate(Vector3.up, 90.0f * Time.deltaTime);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		Instantiate(KeyPoof, transform.position, Quaternion.Euler(0, 270, 0));
        // Make sure the poof animates vertically

		keyStatus = true;

        // Call the Unlock() method on the Door
		door.GetComponent<Door> ().Unlock();

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject, 1.0f);
    }

}
