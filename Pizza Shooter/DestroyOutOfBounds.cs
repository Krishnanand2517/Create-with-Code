using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {

	private float topBound = 30.0f;
	private float lowerBound = -10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// If object goes out of screen, destroy that
		if (transform.position.z > topBound)
		{
			Destroy(gameObject);
		} else if (transform.position.z < lowerBound)
		{
			Debug.Log("Game Over!!");
			Destroy(gameObject);
		}
	}
}
