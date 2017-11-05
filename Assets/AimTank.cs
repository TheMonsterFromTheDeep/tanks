using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTank : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, Mathf.Infinity, 1 << 8)) {
			transform.eulerAngles = new Vector3 (90, Mathf.Rad2Deg * Mathf.Atan2 (hit.point.x - transform.position.x, hit.point.z - transform.position.z), 0);
		}
	}
}
