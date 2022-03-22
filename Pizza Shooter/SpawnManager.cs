﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public GameObject[] animalPrefabs;
	private float spawnRangeX = 20.0f;
	private float spawnPosZ = 20.0f;
	private float startDelay = 2.0f;
	private float spawnInterval = 1.5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnRandomAnimal() {
		int animalIndex = Random.Range(0, animalPrefabs.Length);
		Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.5f, spawnPosZ);

		Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
		
	}
}
