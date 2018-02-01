using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu:MonoBehaviour {
	
	[SerializeField]
	private GameObject mainMenu;
	[SerializeField]
	private GameObject options;
	[SerializeField]
	private GameObject options_Game;
	[SerializeField]
	private GameObject options_Graphics;
	[SerializeField]
	private GameObject options_Audio;
	[SerializeField]
	private GameObject options_Controls;

	public void NewGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadGame() {
	
	}

	public void LevelSelect() {
	
	}

	public void Options() {
		mainMenu.SetActive(false);
		options_Game.SetActive(false);
		options_Graphics.SetActive(false);
		options_Audio.SetActive(false);
		options_Controls.SetActive(false);
		options.SetActive(true);
	}

	public void Options_Game() {
		mainMenu.SetActive(false);
		options_Game.SetActive(true);
		options_Graphics.SetActive(false);
		options_Audio.SetActive(false);
		options_Controls.SetActive(false);
		options.SetActive(false);
	}

	public void Options_Graphics() {
		mainMenu.SetActive(false);
		options_Game.SetActive(false);
		options_Graphics.SetActive(true);
		options_Audio.SetActive(false);
		options_Controls.SetActive(false);
		options.SetActive(false);
	}

	public void Options_Audio() {
		mainMenu.SetActive(false);
		options_Game.SetActive(false);
		options_Graphics.SetActive(false);
		options_Audio.SetActive(true);
		options_Controls.SetActive(false);
		options.SetActive(false);
	}

	public void Options_Controls() {
		mainMenu.SetActive(false);
		options_Game.SetActive(false);
		options_Graphics.SetActive(false);
		options_Audio.SetActive(false);
		options_Controls.SetActive(true);
		options.SetActive(false);
	}

	public void Quit() {
		Application.Quit();
	}
}
