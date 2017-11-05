using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject player;
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position;
	}
}
