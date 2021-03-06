using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	float shakings;
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1;

	// Update is called once per frame
	void Update () {
		if (shakings > 0) {
			//print ("GAHAGHGAHGHAGHAG");
			transform.localPosition = Random.insideUnitSphere * shakeAmount;
			shakings -= Time.deltaTime * decreaseFactor;
		}
	}

	public void Shake(float shakeTime){
		this.shakings = Mathf.Max(this.shakings, shakeTime);
		//print ("SHakeTiiime: " + shakings);
	}
}
