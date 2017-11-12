using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMakerManager : MonoBehaviour {

	public float perlinNoise;
	public float refinement;
	public float multiplier;
	public int landWidth;
	public int landLength;
	public float speed;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < landLength; i++)
		{
			for (int j = 0; j < landWidth; j++)
			{
				perlinNoise = Mathf.PerlinNoise(i * refinement, j * refinement);
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				MeshRenderer cubeMesh = cube.GetComponent<MeshRenderer>();
				if(perlinNoise >= 0.75f){
					cubeMesh.material.color = Color.white;
				}
				else if(perlinNoise < 0.75f && perlinNoise >= 0.5f){
					cubeMesh.material.color = Color.gray;
				}
				else if(perlinNoise < 0.5f && perlinNoise >= 0.25f){
					cubeMesh.material.color = Color.green;
				}
				else if(perlinNoise < 0.25f && perlinNoise >= 0f){
					cubeMesh.material.color = Color.cyan;
				}
				cube.AddComponent<CubeMotor>();
				cube.transform.localScale = cube.transform.localScale;
				cube.transform.position = new Vector3(transform.position.x + i, transform.position.y + (perlinNoise * multiplier), transform.position.z + j);
				cube.transform.SetParent(this.gameObject.transform);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

}
