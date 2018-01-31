using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerCtrl:MonoBehaviour {

	public float speed = 12f;
	public bool isMouseEnabled;
	public bool lockCursor = true;

	private PlayerMotor motor;

	private void Start() {
		motor = GetComponent<PlayerMotor>();
		UpdateSettings();
	}

	private void UpdateSettings() {
		motor.isMouseEnabled = isMouseEnabled;
	}

	private void Update() {
		if (motor.isMouseEnabled != isMouseEnabled) {
			UpdateSettings();
		}

		if (Cursor.lockState == CursorLockMode.None && lockCursor == true) {
			Cursor.lockState = CursorLockMode.Confined;
		} else if (Cursor.lockState == CursorLockMode.Confined && lockCursor == false) {
			Cursor.lockState = CursorLockMode.None;
		}

		float _xMov = Input.GetAxisRaw("Key_Horizontal");
		float _zMov = Input.GetAxisRaw("Key_Vertical");

		Vector3 _movHorz = transform.right * _xMov;
		Vector3 _movVert = transform.forward * _zMov;

		Vector3 _velocity = (_movHorz + _movVert).normalized * speed;

		motor.Move(_velocity);
	}
}
