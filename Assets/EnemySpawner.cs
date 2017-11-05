using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		lastTime = Time.time;
	}

	public GameObject enemy;

	float lastTime;
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lastTime > Random.Range (2, 4)) {
			GameObject ne = Instantiate (enemy);

			float theta = Random.Range (0, 6.28f);
			float r = Random.Range (10, 25);

			float x = r * Mathf.Sin (theta);
			float y = r * Mathf.Cos (theta);

			ne.transform.position = transform.position + new Vector3 (x, 0, y);
			lastTime = Time.time;
		}
	}
}
