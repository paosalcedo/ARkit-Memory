using UnityEngine;

public class HideThenPlace : PlaceOnPlane {

	private bool _Searching = true;

	protected override void Start() {
		base.Start();

		transform.position = Vector3.one * 1000000f;
	}

	protected override void Update() {
		base.Update();

		if (_Searching && Positioned) {
			transform.position = Position;
			GetComponentInChildren<AudioSource>().Play();
			_Searching = false;
		}
	}

}