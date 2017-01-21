﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructUnit : MonoBehaviour {

	public GameObject shockWave;

	[HideInInspector]
	public float delay;
	private float timestamp;

	private static float lowestOff = Mathf.Infinity;
	private static float highestOff = Mathf.NegativeInfinity;

	private void Awake() {
		timestamp = Time.time;
	}

	private void Update() {
		if (Time.time >= timestamp + delay) {
#if DEBUG
			// Debugging
			float took = Time.time - timestamp;
			float diff = Mathf.Abs(delay - took);

			if (diff < lowestOff) lowestOff = diff;
			if (diff > highestOff) highestOff = diff;

			print("I LIVED IN " + (Time.time - timestamp) + " SECONDS\nLOWEST ERROR = " + lowestOff + "\nHIGHEST ERROR = " + highestOff);
#endif

			// Do it. Kill it. Good goood
			SendMessage("OnSelfDestruct", SendMessageOptions.DontRequireReceiver);
			Instantiate (shockWave, new Vector3 (transform.position.x, 0, transform.position.z), Quaternion.identity);
			Destroy(gameObject);
		}
	}
}