using System.Collections;
using UnityEngine;

public class BulletCtrl : MonoBehaviour {

	private float lifeTime = 5f;
	private float lifeTimeCounter;

	public float speed;
	public float damage;
	public bool isHoming;
	private bool shouldBeHoming;

	private void Start() {
		lifeTimeCounter = lifeTime;
		float _val = Random.Range(0.15f,0.25f);
		if (isHoming == true) {
			StartCoroutine("HomingStarter", _val);
		}
	}

	private IEnumerator HomingStarter(float time) {
		yield return new WaitForSecondsRealtime(time);
		shouldBeHoming = true;
	}

	public GameObject FindClosestEnemy() {
		GameObject[] enemies;
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
		GameObject closest = null;
		float distance = Mathf.Infinity;
		Vector3 position = transform.position;
		foreach (GameObject enemy in enemies) {
			Vector3 diff = enemy.transform.position - position;
			float curDistance = diff.sqrMagnitude;
			if (curDistance < distance) {
				closest = enemy;
				distance = curDistance;
			}
		}
		return closest;
	}

	void Update() {
		if (shouldBeHoming == false) {
			transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
		} else {
			if (GameObject.FindGameObjectWithTag("Enemy") != null) {
				transform.position = Vector3.MoveTowards(this.transform.position, FindClosestEnemy().transform.position, speed / 50);
			} else {
				transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
			}
		}

		//Kill
		lifeTimeCounter -= Time.deltaTime;
		if (lifeTimeCounter <= 0) {
			Destroy(gameObject);
		}
	}
}
