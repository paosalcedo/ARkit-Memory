using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMakerManager : MonoBehaviour {

	float multiplier = 0;
	float perlinScale;
	float timer;
	float timerMax;
	public float cloudSpeed;
	// Use this for initialization
	void Start () {
		timer = Random.Range(0.1f, 1);
		timerMax = Random.Range(1, 3);
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if(timer <= 0){
			SpawnRandomCloud();
			timer = Random.Range(1,3);
		}
	}

	public void SpawnRandomCloud(){
		GameObject cloud = Instantiate(Resources.Load("cloud"), new Vector3(transform.position.x, Random.Range(20,75), Random.Range(-50,50)), Quaternion.identity) as GameObject;
		cloud.transform.localScale = new Vector3(Random.Range (3,10), Random.Range(3,10), Random.Range(3,10));
		cloud.transform.eulerAngles = new Vector3(0, Random.Range(0,90), 0);
		cloud.GetComponent<CloudMotor>().speed = cloudSpeed;
	}

}
