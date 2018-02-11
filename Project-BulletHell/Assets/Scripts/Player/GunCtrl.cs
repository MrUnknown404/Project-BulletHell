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

	private JsonData js;

	private void Start() {
		js = GameObject.Find("_GameManager").GetComponent<JsonData>();
		if (js == null) {
			Debug.LogError(System.Math.Round(Time.time, 2) + ": PlayerCtrl: Cannot Find _GameManager (Probably switched scenes incorrectly)");
		}
		js.ReadConfig();
		
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
		if (js.saveData.selectedWeapon == 0) {
			amountOfBullets = 1;
			isUsingHoming = false;
		} else if (js.saveData.selectedWeapon == 1) {
			amountOfBullets = 1;
			isUsingHoming = true;
		} else if (js.saveData.selectedWeapon == 2) {
			amountOfBullets = 2;
			isUsingHoming = true;
		} else if (js.saveData.selectedWeapon == 3) {
			amountOfBullets = 3;
			isUsingHoming = true;
		} else if (js.saveData.selectedWeapon == 4) {
			amountOfBullets = 4;
			isUsingHoming = true;
		} else if (js.saveData.selectedWeapon == 5) {
			amountOfBullets = 5;
			isUsingHoming = true;
		} else if (js.saveData.selectedWeapon == 6) {
			amountOfBullets = 2;
			isUsingHoming = false;
		} else if (js.saveData.selectedWeapon == 7) {
			amountOfBullets = 3;
			isUsingHoming = false;
		} else if (js.saveData.selectedWeapon == 8) {
			amountOfBullets = 4;
			isUsingHoming = false;
		} else if (js.saveData.selectedWeapon == 9) {
			amountOfBullets = 5;
			isUsingHoming = false;
		} else if (js.saveData.selectedWeapon == 10) {
			amountOfBullets = 6;
			isUsingHoming = false;
		} else if (js.saveData.selectedWeapon == 11) {
			amountOfBullets = 7;
			isUsingHoming = false;
		}
	}
	
	public void Shoot() {
		if (js.saveData.selectedWeapon == 0) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
		} else if (js.saveData.selectedWeapon == 1) {
			GameObject sbullet0 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.GetComponent<BulletCtrl>().isHoming = true;
		} else if (js.saveData.selectedWeapon == 2) {
			GameObject sbullet0 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet1, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
		} else if (js.saveData.selectedWeapon == 3) {
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
		} else if (js.saveData.selectedWeapon == 4) {
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
		} else if (js.saveData.selectedWeapon == 5) {
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
		} else if (js.saveData.selectedWeapon == 6) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<BulletCtrl>().speed = speed;
			sbullet1.GetComponent<BulletCtrl>().speed = speed;
			sbullet0.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet1.GetComponent<BulletCtrl>().damage = damageReal;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f, 0f);
		} else if (js.saveData.selectedWeapon == 7) {
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
		} else if (js.saveData.selectedWeapon == 8) {
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
		} else if (js.saveData.selectedWeapon == 9) {
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
		} else if (js.saveData.selectedWeapon == 10) {
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
		} else if (js.saveData.selectedWeapon == 11) {
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
