using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	float shakings;
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1;
	Vector3 firstPos;

	void Start(){
		firstPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (shakings > 0) {
			print ("GAHAGHGAHGHAGHAG");
			transform.position = firstPos + Random.insideUnitSphere * shakeAmount;
			shakings -= Time.deltaTime * decreaseFactor;
		} else {

		}
	}
	public void Shake(float shakeTime){
		firstPos = transform.position;
		this.shakings = shakeTime;
		print ("SHakeTiiime: " + shakings);
	}
}
