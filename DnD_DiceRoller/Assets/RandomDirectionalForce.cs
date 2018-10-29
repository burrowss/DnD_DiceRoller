using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDirectionalForce : MonoBehaviour {

	public string button = "Fire1";
	public float newtons = 10.0f;
	public float torque = 10.0f;
	public ForceMode forceMode;

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown(button)){
			GetComponent<Rigidbody>().AddForce(Random.onUnitSphere * newtons, forceMode);
			GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere * torque, forceMode);
		}
	}
}
