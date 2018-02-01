using UnityEngine;

public class EnemyCtrl:MonoBehaviour {

	[Header("Default Stats")]
	public float maxHealth;
	public float health;
	public float speed = 6;
	public float fireRate;
	[SerializeField]
	private AttackType attackType;
	
	private bool canAttack = true;
	private bool once;

	[SerializeField]
	private GameObject healthBar;

	private enum AttackType {
		Normal,
		Spread2x,
		Spread3x,
		Spread4x,
		Spread5x,
		Spread6x,
		Spread7x,
		CirShot6x,
		CirShot8x,
		CirShot12x,
		Spiral
	};

	[Header("Bullets")]
	[SerializeField]
	private GameObject bullet0;

	private void Start() {
		health = maxHealth;
		InvokeRepeating("Shoot", fireRate, fireRate);
	}

	private void Update() {
		if (health <= 0) {
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Bullet") {
			health -= col.gameObject.GetComponent<BulletCtrl>().damage;
			Destroy(col.gameObject);

			float calcHealth = health / maxHealth;
			SetHealthBar(calcHealth);
		}
	}

	public void SetHealthBar(float myHealth) {
		healthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}

	private void Shoot() {
		if (canAttack == false) {
			return;
		}

		if (attackType == AttackType.Normal) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
		} else if (attackType == AttackType.Spread2x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f + 180f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f + 180f, 0f);
		} else if (attackType == AttackType.Spread3x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet2.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f + 180f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f + 180f, 0f);
		} else if (attackType == AttackType.Spread4x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet2.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet3.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f + 180f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f + 180f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 15f + 180f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -15f + 180f, 0f);
		} else if (attackType == AttackType.Spread5x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet2.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet3.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet4.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f + 180f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f + 180f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 20f + 180f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -20f + 180f, 0f);
		} else if (attackType == AttackType.Spread6x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet5 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet2.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet3.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet4.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet5.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 5f + 180f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -5f + 180f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 15f + 180f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -15f + 180f, 0f);
			sbullet4.transform.rotation = Quaternion.Euler(0f, 25f + 180f, 0f);
			sbullet5.transform.rotation = Quaternion.Euler(0f, -25f + 180f, 0f);
		} else if (attackType == AttackType.Spread7x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet5 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet6 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet2.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet3.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet4.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet5.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet6.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 10f + 180f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -10f + 180f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 20f + 180f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -20f + 180f, 0f);
			sbullet4.transform.rotation = Quaternion.Euler(0f, 30f + 180f, 0f);
			sbullet5.transform.rotation = Quaternion.Euler(0f, -30f + 180f, 0f);
		} else if (attackType == AttackType.CirShot6x) {
			if (once == true) {
				GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet5 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet2.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet3.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet4.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet5.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet0.transform.rotation = Quaternion.Euler(0f, 10f + 180f, 0f);
				sbullet1.transform.rotation = Quaternion.Euler(0f, -10f + 180f, 0f);
				sbullet2.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
				sbullet3.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
				sbullet5.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				once = false;
			} else {
				GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				GameObject sbullet5 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
				sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet2.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet3.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet4.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet5.GetComponent<EnemyBulletCtrl>().speed = speed;
				sbullet0.transform.rotation = Quaternion.Euler(0f, 10f + 90f, 0f);
				sbullet1.transform.rotation = Quaternion.Euler(0f, -10f + 90f, 0f);
				sbullet2.transform.rotation = Quaternion.Euler(0f, 10f - 90f, 0f);
				sbullet3.transform.rotation = Quaternion.Euler(0f, -10f - 90f, 0f);
				sbullet4.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
				sbullet5.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
				once = true;
			}
		} else if (attackType == AttackType.CirShot8x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet5 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet6 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet7 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet2.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet3.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet4.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet5.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet6.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet7.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 45f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 135f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			sbullet4.transform.rotation = Quaternion.Euler(0f, 225f, 0f);
			sbullet5.transform.rotation = Quaternion.Euler(0f, 270f, 0f);
			sbullet6.transform.rotation = Quaternion.Euler(0f, 315f, 0f);
			sbullet7.transform.rotation = Quaternion.Euler(0f, 360f, 0f);
		} else if (attackType == AttackType.CirShot12x) {
			GameObject sbullet0 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet1 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet2 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet3 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet4 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet5 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet6 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet7 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet8 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet9 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet10 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			GameObject sbullet11 = Instantiate(bullet0, this.gameObject.transform.position, this.gameObject.transform.rotation, GameObject.Find("BulletHolder").transform);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet1.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet2.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet3.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet4.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet5.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet6.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet7.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet8.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet9.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet10.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet11.GetComponent<EnemyBulletCtrl>().speed = speed;
			sbullet0.transform.rotation = Quaternion.Euler(0f, 20f + 180f, 0f);
			sbullet1.transform.rotation = Quaternion.Euler(0f, -20f + 180f, 0f);
			sbullet2.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
			sbullet3.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
			sbullet4.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			sbullet5.transform.rotation = Quaternion.Euler(0f, 20f + 90f, 0f);
			sbullet6.transform.rotation = Quaternion.Euler(0f, -20f + 90f, 0f);
			sbullet7.transform.rotation = Quaternion.Euler(0f, 20f - 90f, 0f);
			sbullet8.transform.rotation = Quaternion.Euler(0f, -20f - 90f, 0f);
			sbullet9.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
			sbullet10.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
		}
	}
}
