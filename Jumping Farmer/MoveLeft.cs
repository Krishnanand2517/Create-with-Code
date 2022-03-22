﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

	private float speed = 30;
	private float leftBound = -15;		//delete if object is beyond this
	private PlayerController playerControllerScript;

	// Use this for initialization
	void Start () {
		playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerControllerScript.gameOver == false){
			transform.Translate(Vector3.left * Time.deltaTime * speed);
		}

		if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")){
			Destroy(gameObject);
		}
	}
}
