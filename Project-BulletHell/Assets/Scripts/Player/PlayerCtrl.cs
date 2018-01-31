using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
[RequireComponent(typeof(GunCtrl))]
public class PlayerCtrl : MonoBehaviour {

	public float speed = 12f;
	public bool isMouseEnabled;
	public bool lockCursor = true;
	public bool isAutoFireOn = true;

	private float timeLeft;
	private float fireRate;
	private bool startTimer = false;

	private PlayerMotor motor;
	private GunCtrl gun;

	private void Start() {
		motor = GetComponent<PlayerMotor>();
		gun = GetComponent<GunCtrl>();
		fireRate = gun.fireRate;
		timeLeft = gun.fireRate;
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

		if (isAutoFireOn == true && startTimer == false) {
			gun.Shoot();
			startTimer = true;
		} else if(isAutoFireOn == false && startTimer == false) {
			if (Input.GetButton("Mouse_0")) {
				gun.Shoot();
				startTimer = true;
			}
		}

		//Timer
		if (startTimer == true) {
			timeLeft -= Time.fixedDeltaTime;
			timeLeft = Mathf.Clamp(timeLeft, 0, fireRate);
			if (timeLeft == 0) {
				timeLeft = fireRate;
				startTimer = false;
			}
		}

		float _xMov = Input.GetAxisRaw("Key_Horizontal");
		float _zMov = Input.GetAxisRaw("Key_Vertical");

		Vector3 _movHorz = transform.right * _xMov;
		Vector3 _movVert = transform.forward * _zMov;

		Vector3 _velocity = (_movHorz + _movVert).normalized * speed;

		motor.Move(_velocity);
	}
}
