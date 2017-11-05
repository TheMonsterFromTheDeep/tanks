using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.CompareTag ("enemy")) {
			Destroy (c.gameObject);
		}
	}
}
