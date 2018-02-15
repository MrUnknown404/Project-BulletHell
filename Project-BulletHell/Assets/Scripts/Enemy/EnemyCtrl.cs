using UnityEngine;

public class EnemyCtrl:MonoBehaviour {

	[Header("Default Stats")]
	public float maxHealth = 15000;
	public float health;
	public float speed = 6;
	public float fireRate = 0.6f;
	public float spiralRotateSpeed = 8f;
	[SerializeField]
	private AttackType attackType;
	
	private bool canAttack = true;
	private bool once;
	private Transform bulletHolder;

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
		bulletHolder = GameObject.Find("BulletHolder").transform;
	}

	private void Update() {
		if (health <= 0) {
			Destroy(gameObject);
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
			GameObject sbullet0 = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
			sbullet0.GetComponent<EnemyBulletCtrl>().speed = speed;
		} else if (attackType == AttackType.Spread2x) {
			for (int i = 0; i < 2; i++) {
				GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 5f + 180f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -5f + 180f, 0f);
				}
			}
		} else if (attackType == AttackType.Spread3x) {
			for (int i = 0; i < 3; i++) {
				GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 10f + 180f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -10f + 180f, 0f);
				}
			}
		} else if (attackType == AttackType.Spread4x) {
			for (int i = 0; i < 4; i++) {
				GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 5f + 180f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -5f + 180f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 15f + 180f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -15f + 180f, 0f);
				}
			}
		} else if (attackType == AttackType.Spread5x) {
			for (int i = 0; i < 5; i++) {
				GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 10f + 180f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -10f + 180f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 20f + 180f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -20f + 180f, 0f);
				}
			}
		} else if (attackType == AttackType.Spread6x) {
			for (int i = 0; i < 6; i++) {
				GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 5f + 180f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -5f + 180f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 15f + 180f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -15f + 180f, 0f);
				} else if (i == 4) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 25f + 180f, 0f);
				} else if (i == 5) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -25f + 180f, 0f);
				}
			}
		} else if (attackType == AttackType.Spread7x) {
			for (int i = 0; i < 7; i++) {
				GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 10f + 180f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -10f + 180f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 20f + 180f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -20f + 180f, 0f);
				} else if (i == 4) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 30f + 180f, 0f);
				} else if (i == 5) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -30f + 180f, 0f);
				}
			}
		} else if (attackType == AttackType.CirShot6x) {
			if (once == true) {
				for (int i = 0; i < 6; i++) {
					GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
					_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
					if (i == 0) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, 10f + 180f, 0f);
					} else if (i == 1) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, -10f + 180f, 0f);
					} else if (i == 2) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, 10f, 0f);
					} else if (i == 3) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, -10f, 0f);
					} else if (i == 4) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
					}
				}
				once = false;
			} else {
				for (int i = 0; i < 6; i++) {
					GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
					_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
					if (i == 0) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, 10f + 90f, 0f);
					} else if (i == 1) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, -10f + 90f, 0f);
					} else if (i == 2) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, 10f - 90f, 0f);
					} else if (i == 3) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, -10f - 90f, 0f);
					} else if (i == 4) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
					} else if (i == 5) {
						_sbullet.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
					}
				}
				once = true;
			}
		} else if (attackType == AttackType.CirShot8x) {
			for (int i = 0; i < 8; i++) {
				GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 45f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 135f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
				} else if (i == 4) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 225f, 0f);
				} else if (i == 5) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 270f, 0f);
				} else if (i == 6) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 315f, 0f);
				} else if (i == 7) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 360f, 0f);
				}
			}
		} else if (attackType == AttackType.CirShot12x) {
			for (int i = 0; i < 12; i++) {
				GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
				_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
				if (i == 0) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 20f + 180f, 0f);
				} else if (i == 1) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -20f + 180f, 0f);
				} else if (i == 2) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 20f, 0f);
				} else if (i == 3) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
				} else if (i == 4) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				} else if (i == 5) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 20f + 90f, 0f);
				} else if (i == 6) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -20f + 90f, 0f);
				} else if (i == 7) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 20f - 90f, 0f);
				} else if (i == 8) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -20f - 90f, 0f);
				} else if (i == 9) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
				} else if (i == 10) {
					_sbullet.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
				}
			}
		} else if (attackType == AttackType.Spiral) {
			if (!IsInvoking("Spiral")) {
				InvokeRepeating("Spiral", 0, fireRate);
			}
		}
	}

	private float val = 0;

	private void Spiral() {
		GameObject _sbullet = Instantiate(bullet0, gameObject.transform.position, gameObject.transform.rotation, bulletHolder);
		_sbullet.GetComponent<EnemyBulletCtrl>().speed = speed;
		val++;
		_sbullet.transform.rotation = Quaternion.Euler(0f, val * spiralRotateSpeed, 0f);
		if ((val * spiralRotateSpeed) >= 360) {
			val = 0;
		}
	}
}
