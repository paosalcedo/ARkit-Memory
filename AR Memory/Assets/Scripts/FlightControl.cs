using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FlightControl : MonoBehaviour {

	public float perlinJitter;
	public float yMultiplier;
	public float xMultiplier;
	public float zMultiplier;
	Vector3 startPos;

	float timeScale = 0.251f;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		perlinJitter = Mathf.PerlinNoise(Time.time * timeScale,0);
		FlightJitter();
	}

	public void FlightJitter(){
		transform.position = new Vector3 (perlinJitter * xMultiplier, startPos.y + (perlinJitter * yMultiplier), perlinJitter * zMultiplier);
	}

 
}
