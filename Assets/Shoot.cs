using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject missile;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject nm = Instantiate (missile);
			nm.transform.position = transform.position;
			nm.transform.forward = transform.up;
		}
	}
}
