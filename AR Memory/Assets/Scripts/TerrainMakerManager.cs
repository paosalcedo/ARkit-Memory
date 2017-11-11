using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMakerManager : MonoBehaviour {

	public float perlinNoise;
	public float refinement;
	public float multiplier;
	public int cubes;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < cubes; i++)
		{
			for (int j = 0; j < cubes; j++)
			{
				perlinNoise = Mathf.PerlinNoise(i * refinement, j * refinement);
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3(transform.position.x + i, transform.position.y + (perlinNoise * multiplier), transform.position.z + j);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
