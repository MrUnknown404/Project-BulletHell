using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
[RequireComponent(typeof(GunCtrl))]
public class PlayerCtrl : MonoBehaviour {

	public float speed = 12f;
	public int maxBombCount = 3;
	public int bombCount;
	public bool lockCursor = true;
	public bool isAutoFireOn = true;
	
	private float fireRate;
	private bool isMouseEnabled;

	private PlayerMotor motor;
	private GunCtrl gun;
	private JsonData gm;

	private void Start() {
		motor = GetComponent<PlayerMotor>();
		gun = GetComponent<GunCtrl>();
		fireRate = gun.fireRate;
		bombCount = maxBombCount;
		UpdateSettings();

		gm = GameObject.Find("_GameManager").GetComponent<JsonData>();
		gm.ReadConfig();

		gm.ReadConfig();
		Debug.Log(isMouseEnabled);
		Debug.Log(gm.gameData.useMouse);
		isMouseEnabled = gm.gameData.useMouse;
		Debug.Log(isMouseEnabled);
		Debug.Log(gm.gameData.useMouse);
	}

	private void UpdateSettings() {
		motor.isMouseEnabled = isMouseEnabled;
	}

	private void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "EnemyBullet") {
			Destroy(this.gameObject);
		}
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

		if (Input.GetButtonDown("Key_Bomb")) {
			if (bombCount <= 0) {
				return;
			}
			bombCount--;
			GameObject[] bullets = GameObject.FindGameObjectsWithTag("EnemyBullet");
			foreach (GameObject bullet in bullets) {
				Destroy(bullet.gameObject);
			}
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
