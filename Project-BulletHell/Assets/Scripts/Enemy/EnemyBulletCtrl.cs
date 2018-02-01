using System.Collections;
using UnityEngine;

public class EnemyBulletCtrl : MonoBehaviour {

	private float lifeTime = 10f;
	private float lifeTimeCounter;

	public float speed;
	public bool isHoming;
	private bool shouldBeHoming;

	private void Start() {
		lifeTimeCounter = lifeTime;
		float _val = Random.Range(0.3f, 0.4f);
		if (isHoming == true) {
			StartCoroutine("HomingStarter", _val);
		}
	}

	private IEnumerator HomingStarter(float time) {
		yield return new WaitForSecondsRealtime(time);
		shouldBeHoming = true;
	}

	void Update() {
		if (shouldBeHoming == false) {
			transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
		} else {
			if (GameObject.FindGameObjectWithTag("Player") != null) {
				transform.position = Vector3.MoveTowards(this.transform.position, GameObject.FindGameObjectWithTag("Enemy").transform.position, speed / 50);
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
