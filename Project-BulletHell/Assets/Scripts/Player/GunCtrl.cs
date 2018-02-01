using UnityEngine;

public class GunCtrl:MonoBehaviour {

	[Header("Default Stats")]
	public float damageReal;
	public float damage = 100;
	public float damageMulti = 1.00f;
	public float speed = 12;
	public float fireRate = 0.1f;
	public WeaponType weaponType;

	private bool isUsingHoming;

	private int amountOfBullets;

	[Header("Bullets")]
	[SerializeField]
	private GameObject bullet0;
	[SerializeField]
	private GameObject bullet1;

	public enum WeaponType {
		Normal,
		Homing1x,
		Homing2x,
		Homing3x,
		Homing4x,
		Homing5x,
		Spread2x,
		Spread3x,
		Spread4x,
		Spread5x,
		Spread6x,
		Spread7x
	};

	private void Start() {
		UpdateWeapon();
		UpdateSettings();
	}

	private void Update() {
		//change to when weapon change run this
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
		if (weaponType == WeaponType.Normal) {
			amountOfBullets = 1;
			isUsingHoming = false;
		} else if (weaponType == WeaponType.Homing1x) {
			amountOfBullets = 1;
			isUsingHoming = true;
		} else if (weaponType == WeaponType.Homing2x) {
			amountOfBullets = 2;
			isUsingHoming = true;
		} else if (weaponType == WeaponType.Homing3x) {
			amountOfBullets = 3;
			isUsingHoming = true;
		} else if (weaponType == WeaponType.Homing4x) {
			amountOfBullets = 4;
			isUsingHoming = true;
		} else if (weaponType == WeaponType.Homing5x) {
			amountOfBullets = 5;
			isUsingHoming = true;
		} else if (weaponType == WeaponType.Spread2x) {
			amountOfBullets = 2;
			isUsingHoming = false;
		} else if (weaponType == WeaponType.Spread3x) {
			amountOfBullets = 3;
			isUsingHoming = false;
		} else if (weaponType == WeaponType.Spread4x) {
			amountOfBullets = 4;
			isUsingHoming = false;
		} else if (weaponType == WeaponType.Spread5x) {
			amountOfBullets = 5;
			isUsingHoming = false;
		} else if (weaponType == WeaponType.Spread6x) {
			amountOfBullets = 6;
			isUsingHoming = false;
		} else if (weaponType == WeaponType.Spread7x) {
			amountOfBullets = 7;
			isUsingHoming = false;
		}
	}
	
	public void Shoot() {
		if (weaponType == WeaponType.Normal) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
		} else if (weaponType == WeaponType.Homing1x) {
			GameObject sbullet0 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.GetComponent<BulletCtrl>().isHoming = true;
		} else if (weaponType == WeaponType.Homing2x) {
			GameObject sbullet0 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
		} else if (weaponType == WeaponType.Homing3x) {
			GameObject sbullet0 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet2.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
		} else if (weaponType == WeaponType.Homing4x) {
			GameObject sbullet0 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet3.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet2.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet3.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 15f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
		} else if (weaponType == WeaponType.Homing5x) {
			GameObject sbullet0 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet4 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet3.GetComponent<BulletCtrl>().speed = speed;
			sbullet4.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet2.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet3.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet4.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
		} else if (weaponType == WeaponType.Spread2x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
		} else if (weaponType == WeaponType.Spread3x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet2.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
		} else if (weaponType == WeaponType.Spread4x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet3.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet2.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet3.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 15f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
		} else if (weaponType == WeaponType.Spread5x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet3.GetComponent<BulletCtrl>().speed = speed;
			sbullet4.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet2.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet3.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet4.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
		} else if (weaponType == WeaponType.Spread6x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet5 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet3.GetComponent<BulletCtrl>().speed = speed;
			sbullet4.GetComponent<BulletCtrl>().speed = speed;
			sbullet5.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet2.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet3.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet4.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet5.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 15f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
			sbullet4.transform.rotation = Quaternion.Euler(0f, 25f, 0f);
			sbullet5.transform.rotation = Quaternion.Euler(0f, -25f, 0f);
		} else if (weaponType == WeaponType.Spread7x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet5 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet6 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet3.GetComponent<BulletCtrl>().speed = speed;
			sbullet4.GetComponent<BulletCtrl>().speed = speed;
			sbullet5.GetComponent<BulletCtrl>().speed = speed;
			sbullet6.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet2.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet3.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet4.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet5.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet6.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
			sbullet4.transform.rotation = Quaternion.Euler(0f, 30f, 0f);
			sbullet5.transform.rotation = Quaternion.Euler(0f, -30f, 0f);
		}
	}
}
