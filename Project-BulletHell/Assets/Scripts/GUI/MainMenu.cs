using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu:MonoBehaviour {
	
	[SerializeField]
	private GameObject mainMenuOptions;
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

	private JsonData gm;

	[Header("Config")]
	[SerializeField]
	private Toggle toggle1;
	[SerializeField]
	private Toggle toggle2;
	[SerializeField]
	private Slider slider1;

	private void Start() {
		gm = GameObject.Find("_GameManager").GetComponent<JsonData>();
		gm.ReadConfig();
		toggle1.isOn = gm.gameData.useMouse;
		toggle2.isOn = gm.gameData.useAutoFire;
		slider1.value = gm.gameData.moveSpeed;
	}

	public void NewGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadGame() {
	
	}

	public void LevelSelect() {
	
	}

	public void Options() {
		mainMenuOptions.SetActive(false);
		options_Game.SetActive(false);
		options_Graphics.SetActive(false);
		options_Audio.SetActive(false);
		options_Controls.SetActive(false);
		options.SetActive(true);
	}

	public void Options_Game() {
		mainMenuOptions.SetActive(false);
		options_Game.SetActive(true);
		options_Graphics.SetActive(false);
		options_Audio.SetActive(false);
		options_Controls.SetActive(false);
		options.SetActive(false);
	}

	public void Options_Graphics() {
		mainMenuOptions.SetActive(false);
		options_Game.SetActive(false);
		options_Graphics.SetActive(true);
		options_Audio.SetActive(false);
		options_Controls.SetActive(false);
		options.SetActive(false);
	}

	public void Options_Audio() {
		mainMenuOptions.SetActive(false);
		options_Game.SetActive(false);
		options_Graphics.SetActive(false);
		options_Audio.SetActive(true);
		options_Controls.SetActive(false);
		options.SetActive(false);
	}

	public void Options_Controls() {
		mainMenuOptions.SetActive(false);
		options_Game.SetActive(false);
		options_Graphics.SetActive(false);
		options_Audio.SetActive(false);
		options_Controls.SetActive(true);
		options.SetActive(false);
	}

	public void Options_Reset() {
		mainMenuOptions.SetActive(true);
		options_Game.SetActive(false);
		options_Graphics.SetActive(false);
		options_Audio.SetActive(false);
		options_Controls.SetActive(false);
		options.SetActive(false);
	}

	public void Controls_MoveSpeed() {
		gm.gameData.moveSpeed = slider1.value;
		gm.SaveConfig();
	}

	public void Controls_UseMouse() {
		gm.gameData.useMouse = toggle1.isOn;
		gm.SaveConfig();
	}

	public void Controls_UseAutoFire() {
		gm.gameData.useAutoFire = toggle2.isOn;
		gm.SaveConfig();
	}

	public void Quit() {
		Application.Quit();
	}
}
