using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code to apply a random direction on dice (rolling them)
public class RandomDirectionalForce : MonoBehaviour {

	// Creating initial variables to be used
	public string button = "Fire1";
	public float newtons = 10.0f;
	public float torque = 10.0f;
	public ForceMode forceMode;

	// Update is called once per frame
	// If mouse is clicked, applies a random force to all dice. Foce is changed in Unity
	void Update () {
		if(Input.GetButtonDown(button)){
			GetComponent<Rigidbody>().AddForce(Random.onUnitSphere * newtons, forceMode);
			GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere * torque, forceMode);
		}
	}
}
