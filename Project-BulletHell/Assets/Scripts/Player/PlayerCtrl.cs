using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
[RequireComponent(typeof(GunCtrl))]
public class PlayerCtrl : MonoBehaviour {

	[SerializeField]
	private GameObject deathGUI;

	public int maxBombCount = 3;
	public int bombCount;
	public bool lockCursor = true;

	private float speed;
	private float fireRate;
	private bool isMouseEnabled;
	private bool isAutoFireOn;

	private PlayerMotor motor;
	private GunCtrl gun;
	private JsonData js;
	private GameManager gm;

	private void Start() {
		motor = GetComponent<PlayerMotor>();
		gun = GetComponent<GunCtrl>();
		gm = GameObject.Find("_GameManager").GetComponent<GameManager>();
		fireRate = gun.fireRate;
		bombCount = maxBombCount;
		UpdateSettings();

		js = GameObject.Find("_GameManager").GetComponent<JsonData>();
		if (js == null) {
			Debug.LogError(System.Math.Round(Time.time, 2) + ": PlayerCtrl: Cannot Find _GameManager (Probably switches scenes incorrectly)");
		}
		js.ReadConfig();

		js.ReadConfig();
		speed = js.configData.moveSpeed;
		isMouseEnabled = js.configData.useMouse;
		isAutoFireOn = js.configData.useAutoFire;
	}

	private void UpdateSettings() {
		if (motor.isMouseEnabled != isMouseEnabled) {
			motor.isMouseEnabled = isMouseEnabled;
		}

		if (isAutoFireOn == true && !IsInvoking("Shoot")) {
			InvokeRepeating("Shoot", 0, fireRate);
		} else if (isAutoFireOn == false) {
			if (Input.GetButtonDown("Mouse_0")) {
				InvokeRepeating("Shoot", 0, fireRate);
			} else if (Input.GetButtonUp("Mouse_0")) {
				CancelInvoke("Shoot");
			}
		}
	}

	private void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "EnemyBullet") {
			Debug.Log(System.Math.Round(Time.time, 2) + ": PlayerCtrl: Player Killed!");
			gm.OnDeath(deathGUI);

			Destroy(this.gameObject);
		}
	}

	private void Update() {
		UpdateSettings();

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
