using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathGUIMenu:MonoBehaviour {

	public void Retry() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void Upgrades() {
		SceneManager.LoadScene("MainHub");
	}

	public void QuitToMenu() {
		SceneManager.LoadScene("MainMenu");
	}
}
