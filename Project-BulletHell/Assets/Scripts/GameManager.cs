using UnityEngine;

public class GameManager : MonoBehaviour {
	public static GameManager gm;

	private void Awake() {
		if (gm != null) {
			Debug.LogError(System.Math.Round(Time.time, 2) + ": GameManager: More than one GameManager in scene!");
			Destroy(this.gameObject);
		} else {
			gm = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	public void OnDeath(GameObject _deathGUI) {
		if (_deathGUI != null) {
			_deathGUI.SetActive(true);
		} else {
			Debug.LogError(System.Math.Round(Time.time, 2) + ": GameManager: Cannot find DeathGUI");
		}
	}
}
