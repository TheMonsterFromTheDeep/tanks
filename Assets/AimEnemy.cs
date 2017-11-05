using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	public GameObject player;
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3 (90, Mathf.Rad2Deg * Mathf.Atan2 (player.transform.position.x - transform.position.x, player.transform.position.z - transform.position.z), 0);
	}
}
