using UnityEngine;

public class GunCtrl:MonoBehaviour {

	[Header("Default Stats")]
	private float damage2;
	public float damage = 100;
	public float speed = 12;
	public float fireRate = 0.1f;
	public WeaponType weaponType;

	private int amountOfBullets;

	[Header("Bullets")]
	[SerializeField]
	private GameObject bullet0;

	public enum WeaponType {
		Normal,
		Homing1x,
		Homing2x,
		Homing3x,
		Homing4x,
		Homing5x,
		Split2x,
		Split3x,
		Split4x,
		Split5x,
		Split6x,
		Split7x
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
		damage2 = damage / amountOfBullets;
	}

	private void UpdateWeapon() {
		if (weaponType == WeaponType.Normal) {
			amountOfBullets = 1;
		} else if (weaponType == WeaponType.Homing1x) {
			amountOfBullets = 1;
		} else if (weaponType == WeaponType.Homing2x) {
			amountOfBullets = 2;
		} else if (weaponType == WeaponType.Homing3x) {
			amountOfBullets = 3;
		} else if (weaponType == WeaponType.Homing4x) {
			amountOfBullets = 4;
		} else if (weaponType == WeaponType.Homing5x) {
			amountOfBullets = 5;
		} else if (weaponType == WeaponType.Split2x) {
			amountOfBullets = 2;
		} else if (weaponType == WeaponType.Split3x) {
			amountOfBullets = 3;
		} else if (weaponType == WeaponType.Split4x) {
			amountOfBullets = 4;
		} else if (weaponType == WeaponType.Split5x) {
			amountOfBullets = 5;
		} else if (weaponType == WeaponType.Split6x) {
			amountOfBullets = 6;
		} else if (weaponType == WeaponType.Split7x) {
			amountOfBullets = 7;
		}
	}
	
	public void Shoot() {
		if (weaponType == WeaponType.Normal) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
		} else if (weaponType == WeaponType.Homing1x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.GetComponent<BulletCtrl>().isHoming = true;
		} else if (weaponType == WeaponType.Homing2x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.GetComponent<BulletCtrl>().isHoming = true;
			sbullet1.GetComponent<BulletCtrl>().isHoming = true;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
		} else if (weaponType == WeaponType.Homing3x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet2.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.GetComponent<BulletCtrl>().isHoming = true;
			sbullet1.GetComponent<BulletCtrl>().isHoming = true;
			sbullet2.GetComponent<BulletCtrl>().isHoming = true;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
		} else if (weaponType == WeaponType.Homing4x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet3.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet2.GetComponent<BulletCtrl>().damage = damage2;
			sbullet3.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.GetComponent<BulletCtrl>().isHoming = true;
			sbullet1.GetComponent<BulletCtrl>().isHoming = true;
			sbullet2.GetComponent<BulletCtrl>().isHoming = true;
			sbullet3.GetComponent<BulletCtrl>().isHoming = true;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 15f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
		} else if (weaponType == WeaponType.Homing5x) {
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
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet2.GetComponent<BulletCtrl>().damage = damage2;
			sbullet3.GetComponent<BulletCtrl>().damage = damage2;
			sbullet4.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.GetComponent<BulletCtrl>().isHoming = true;
			sbullet1.GetComponent<BulletCtrl>().isHoming = true;
			sbullet2.GetComponent<BulletCtrl>().isHoming = true;
			sbullet3.GetComponent<BulletCtrl>().isHoming = true;
			sbullet4.GetComponent<BulletCtrl>().isHoming = true;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
		} else if (weaponType == WeaponType.Split2x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
		} else if (weaponType == WeaponType.Split3x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet2.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
		} else if (weaponType == WeaponType.Split4x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet2.GetComponent<BulletCtrl>().speed = speed;
			sbullet3.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet2.GetComponent<BulletCtrl>().damage = damage2;
			sbullet3.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 15f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
		} else if (weaponType == WeaponType.Split5x) {
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
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet2.GetComponent<BulletCtrl>().damage = damage2;
			sbullet3.GetComponent<BulletCtrl>().damage = damage2;
			sbullet4.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
		} else if (weaponType == WeaponType.Split6x) {
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
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet2.GetComponent<BulletCtrl>().damage = damage2;
			sbullet3.GetComponent<BulletCtrl>().damage = damage2;
			sbullet4.GetComponent<BulletCtrl>().damage = damage2;
			sbullet5.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 15f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
			sbullet4.transform.rotation = Quaternion.Euler(0f, 25f, 0f);
			sbullet5.transform.rotation = Quaternion.Euler(0f, -25f, 0f);
		} else if (weaponType == WeaponType.Split7x) {
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
			sbullet0.GetComponent<BulletCtrl>().damage = damage2;
			sbullet1.GetComponent<BulletCtrl>().damage = damage2;
			sbullet2.GetComponent<BulletCtrl>().damage = damage2;
			sbullet3.GetComponent<BulletCtrl>().damage = damage2;
			sbullet4.GetComponent<BulletCtrl>().damage = damage2;
			sbullet5.GetComponent<BulletCtrl>().damage = damage2;
			sbullet6.GetComponent<BulletCtrl>().damage = damage2;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
			sbullet4.transform.rotation = Quaternion.Euler(0f, 30f, 0f);
			sbullet5.transform.rotation = Quaternion.Euler(0f, -30f, 0f);
		}
	}
}
