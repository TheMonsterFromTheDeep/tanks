using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}

	public float speed = 50;

	float startTime;
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * speed * Time.deltaTime;

		if (Time.time - startTime > 20) {
			Destroy (gameObject);
		}
	}
}
