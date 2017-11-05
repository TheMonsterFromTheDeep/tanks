using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		lastTime = Time.time;
	}

	float lastTime;

	public GameObject missile;
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lastTime > 3) {
			GameObject nm = Instantiate (missile);
			nm.transform.position = transform.position;
			nm.transform.forward = transform.up;
			lastTime = Time.time;
		}
	}
}
