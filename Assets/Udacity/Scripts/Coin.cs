using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject CoinPoof;

	void Update()
	{
		//Bonus: Coin Animation
		transform.Rotate(Vector3.up, 90.0f * Time.deltaTime);
	}

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		Instantiate(CoinPoof, transform.position,Quaternion.Euler(0, -290, 0));
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject, 1.0f);
    }

}
