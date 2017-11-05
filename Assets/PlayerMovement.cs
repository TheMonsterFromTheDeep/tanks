using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.forward = new Vector3 (-1, 0, -0);
	}

	float ax, az;
	float vx, vz;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			az = 5;
		} else if (Input.GetKey (KeyCode.S)) {
			az = -5;
		} else {
			az = (vz > 0) ? -1 : 1;
			if (Mathf.Abs (vz) < 1.1) {
				vz = 0;
			}
		}

		if (Input.GetKey (KeyCode.A)) {
			ax = -5;
		} else if (Input.GetKey (KeyCode.D)) {
			ax = 5;
		} else {
			ax = (vx > 0) ? -1 : 1;
			if (Mathf.Abs (vx) < 1.1) {
				vx = 0;
			}
		}

		vx += ax * Time.deltaTime;
		vz += az * Time.deltaTime;

		transform.position += new Vector3 (vx, 0, vz) * Time.deltaTime;

		if (Mathf.Abs(vx) > 0.5 || Mathf.Abs(vz) > 0.5) {
			transform.forward = new Vector3 (-vx, 0, -vz).normalized;
		}
	}
}
