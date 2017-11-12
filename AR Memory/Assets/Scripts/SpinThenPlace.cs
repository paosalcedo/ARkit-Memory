using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;

public class SpinThenPlace : PlaceOnPlane {
	public float RotationSpeed;
	public float ProjectionDistance;

	private bool _Searching = true;
	
	// Update is called once per frame
	protected override void Update () {
		base.Update();

		if (!_Searching) {
			return;	
		}

		if (Positioned) {
			transform.position = Position;
			if (Input.touchCount > 0) {
				_Searching = false;
			}
		}	
		else {
			Quaternion rotation = transform.rotation;
			rotation *= Quaternion.AngleAxis(RotationSpeed * Time.deltaTime, Vector3.up);
			transform.rotation = rotation;
			transform.position = Camera.main.transform.position + (Camera.main.transform.forward * ProjectionDistance);
		}
	}
}
