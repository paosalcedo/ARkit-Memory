using UnityEngine;

public class SubstituteThenPlace : PlaceOnPlane {

	public GameObject SubstitutePrefab;
	public float HoverDistance;

	private bool _Searching = true;
	private GameObject _Substitute;

	protected override void Start() {
		base.Start();
		
		_Substitute = Instantiate(SubstitutePrefab);
		transform.position = Vector3.one * 10000f;
	}

	protected override void Update() {
		base.Update();

		if (!_Searching) return;

		if (Positioned) {
			_Substitute.transform.position = Position;
			if (Input.touchCount > 0) {
				_Searching = false;
				transform.position = Position;
				Destroy(_Substitute);
			}
		}
		else {
			_Substitute.transform.position = Camera.main.transform.position +
												(Camera.main.transform.forward);
		}
	}
}