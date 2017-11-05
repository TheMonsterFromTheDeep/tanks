using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollGround : MonoBehaviour {

	Material mat;
	float size = 400;

	public GameObject player;

	// Use this for initialization
	void Start () {
		mat = GetComponent<MeshRenderer> ().material;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 o = -player.transform.position / size;
		mat.mainTextureOffset = new Vector2 (o.x, o.z);
	}
}
