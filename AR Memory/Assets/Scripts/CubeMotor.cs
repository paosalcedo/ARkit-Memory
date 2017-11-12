using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMotor : MonoBehaviour {
	Vector3 startPos;
	// Use this for initialization
	float speed = 5f;
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Teleport();
		MoveTerrain();
	}

	public void MoveTerrain(){
		transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
	}
	public void Teleport(){
		if(transform.position.x <= -25f){
			transform.position = new Vector3(75f, startPos.y, startPos.z);
		}
	}
}
