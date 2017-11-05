using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	public GameObject player;
	
	// Update is called once per frame
	void Update () {
		Vector3 velocity = (player.transform.position - transform.position);
		if (velocity.sqrMagnitude > 10 * 10) 
		{
			velocity.Normalize ();
			transform.forward = -velocity;
			velocity *= 10;

			transform.position += velocity * Time.deltaTime;


		}
	}
}
