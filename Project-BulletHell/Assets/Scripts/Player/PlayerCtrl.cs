using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
[RequireComponent(typeof(GunCtrl))]
public class PlayerCtrl : MonoBehaviour {

	public float speed = 12f;
	public bool isMouseEnabled;
	public bool lockCursor = true;
	public bool isAutoFireOn = true;
	
	private float fireRate;

	private PlayerMotor motor;
	private GunCtrl gun;

	private void Start() {
		motor = GetComponent<PlayerMotor>();
		gun = GetComponent<GunCtrl>();
		fireRate = gun.fireRate;
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

		if (isAutoFireOn == true) {
			InvokeRepeating("Shoot", 0, fireRate);
		} else if (isAutoFireOn == false) {
			if (Input.GetButtonDown("Mouse_0")) {
				InvokeRepeating("Shoot", 0, fireRate);
			} else if (Input.GetButtonUp("Mouse_0")) {
				CancelInvoke("Shoot");
			}
		}

		float _xMov = Input.GetAxisRaw("Key_Horizontal");
		float _zMov = Input.GetAxisRaw("Key_Vertical");

		Vector3 _movHorz = transform.right * _xMov;
		Vector3 _movVert = transform.forward * _zMov;

		Vector3 _velocity = (_movHorz + _movVert).normalized * speed;

		motor.Move(_velocity);
	}

	private void Shoot() {
		gun.Shoot();
	}
}
