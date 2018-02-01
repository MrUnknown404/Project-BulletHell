using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager gm;

	private void Awake() {
		if (gm != null) {
			Debug.LogError(System.Math.Round(Time.time, 2) + ": GameManager: More than one GameManager in scene!");
		} else {
			gm = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
}
