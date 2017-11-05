using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.CompareTag ("Player")) {
			c.transform.position = new Vector3 (0, 0, 0);
		}
	}
}
