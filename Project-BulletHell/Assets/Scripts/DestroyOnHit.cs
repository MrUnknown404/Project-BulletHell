using UnityEngine;

public class DestroyOnHit : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Bullet") {
			Destroy(col.gameObject);
		} else if(col.gameObject.tag == "EnemyBullet") {
			Destroy(col.gameObject);
		}
	}
}
