using UnityEngine;

public class GunCtrl:MonoBehaviour {

	[Header("Default Stats")]
	public float damageReal;
	public float damage = 100;
	public float damageMulti = 1.00f;
	public float speed = 12;
	public float fireRate = 0.1f;

	private bool isUsingHoming;

	private int amountOfBullets;

	[Header("Bullets")]
	[SerializeField]
	private GameObject bullet0;
	[SerializeField]
	private GameObject bullet1;

	private Transform bulletHolder;

	private JsonData js;

	private void Start() {
		js = GameObject.Find("_GameManager").GetComponent<JsonData>();
		if (js == null) {
			Debug.LogError(System.Math.Round(Time.time, 2) + ": PlayerCtrl: Cannot Find _GameManager (Probably switched scenes incorrectly)");
		}
		js.ReadConfig();

		SaveData.WeaponType _value = (SaveData.WeaponType)js.saveData.selectedWeapon;
		js.saveData.weaponType = _value;

		bulletHolder = GameObject.Find("BulletHolder").transform;
		;

		UpdateWeapon();
		UpdateSettings();
	}
	
	private void UpdateSettings() {
		if (isUsingHoming == true) {
			damageReal = (((damage + ((amountOfBullets - 1) * 10)) * damageMulti) / amountOfBullets) * 0.6f;
		} else {
			damageReal = ((damage + ((amountOfBullets - 1) * 10)) * damageMulti) / amountOfBullets;
		}
	}

	private void UpdateWeapon() {
		if (js.saveData.weaponType == SaveData.WeaponType.Normal) {
			amountOfBullets = 1;
			isUsingHoming = false;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing1x) {
			amountOfBullets = 1;
			isUsingHoming = true;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing2x) {
			amountOfBullets = 2;
			isUsingHoming = true;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing3x) {
			amountOfBullets = 3;
			isUsingHoming = true;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing4x) {
			amountOfBullets = 4;
			isUsingHoming = true;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing5x) {
			amountOfBullets = 5;
			isUsingHoming = true;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread2x) {
			amountOfBullets = 2;
			isUsingHoming = false;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread3x) {
			amountOfBullets = 3;
			isUsingHoming = false;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread4x) {
			amountOfBullets = 4;
			isUsingHoming = false;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread5x) {
			amountOfBullets = 5;
			isUsingHoming = false;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread6x) {
			amountOfBullets = 6;
			isUsingHoming = false;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread7x) {
			amountOfBullets = 7;
			isUsingHoming = false;
		}
	}
	
	public void Shoot() {
		if (js.saveData.weaponType == SaveData.WeaponType.Normal) {
			GameObject _sbullet = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
			_sbullet.GetComponent<BulletCtrl>().speed = speed;
			_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing1x) {
			GameObject _sbullet = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
			_sbullet.GetComponent<BulletCtrl>().speed = speed;
			_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing2x) {
			Debug.Log("1");
			for (int i = 0; i < 2; i++) {
				GameObject _sbullet = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
				}
			}
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing3x) {
			for (int i = 0; i < 3; i++) {
				GameObject _sbullet = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
				}
			}
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing4x) {
			for (int i = 0; i < 4; i++) {
				GameObject _sbullet = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 15f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
				}
			}
		} else if (js.saveData.weaponType == SaveData.WeaponType.Homing5x) {
			for (int i = 0; i < 5; i++) {
				GameObject _sbullet = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
				}
			}
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread2x) {
			for (int i = 0; i < 2; i++) {
				GameObject _sbullet = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
				}
			}
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread3x) {
			for (int i = 0; i < 3; i++) {
				GameObject _sbullet = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
				}
			}
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread4x) {
			for (int i = 0; i < 4; i++) {
				GameObject _sbullet = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 15f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
				}
			}
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread5x) {
			for (int i = 0; i < 5; i++) {
				GameObject _sbullet = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
				}
			}
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread6x) {
			for (int i = 0; i < 6; i++) {
				GameObject _sbullet = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 15f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
				} else if (i == 4) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 25f, 0f);
				} else if (i == 5) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -25f, 0f);
				}
			}
		} else if (js.saveData.weaponType == SaveData.WeaponType.Spread7x) {// else if (js.saveData.selectedWeapon == 11) {
			for (int i = 0; i < 7; i++) {
				GameObject _sbullet = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<BulletCtrl>().speed = speed;;
				_sbullet.GetComponent<BulletCtrl>().damage = damageReal;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
				} else if (i == 4) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 30f, 0f);
				} else if (i == 5) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -30f, 0f);
				}
			}
		}
	}
}
