using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;

public abstract class PlaceOnPlane : MonoBehaviour {

	public LayerMask CollisionLayerMask;
	public float FindingMinRange = 0.5f;
	public float FindingMaxRange = 30f;

	protected bool Positioned = false;
	protected Vector3 Position;

	// Use this for initialization
	protected virtual void Start () {
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		Vector3 center = new Vector3(Screen.width/2, Screen.height/2, FindingMinRange);	

		Ray ray = Camera.main.ScreenPointToRay(center);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, FindingMaxRange, CollisionLayerMask)) {
			Position = hit.point;
			Positioned = true;
		}
		else {
			Positioned = false;
		}
	}
}
