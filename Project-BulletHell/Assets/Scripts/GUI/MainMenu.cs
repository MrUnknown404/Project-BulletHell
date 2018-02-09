using System.Linq;
using System.Collections.Generic;
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

	private JsonData js;

	[Header("Config")]
	[SerializeField]
	private Toggle toggle1;
	[SerializeField]
	private Toggle toggle2;
	[SerializeField]
	private Toggle toggle3;
	[SerializeField]
	private Slider slider1;
	[SerializeField]
	private Dropdown dropdown1;

	public Resolution[] resolutions;

	private void Start() {
		js = GameObject.Find("_GameManager").GetComponent<JsonData>();
		if (js == null) {
			Debug.LogError(System.Math.Round(Time.time, 2) + ": PlayerCtrl: Cannot Find _GameManager (Probably switched scenes incorrectly)");
		}
		js.ReadConfig();

		toggle1.isOn = js.configData.useMouse;
		toggle2.isOn = js.configData.useAutoFire;
		toggle3.isOn = js.configData.isFullscreen;
		slider1.value = js.configData.moveSpeed;

		Screen.fullScreen = js.configData.isFullscreen;

		//Resolution
		resolutions = Screen.resolutions.Select(resolution => new Resolution { width = resolution.width, height = resolution.height }).Distinct().ToArray();
		List<string> options = new List<string>();
		int currentResIndex = 0;

		dropdown1.ClearOptions();
		
		for (int i = 0; i < resolutions.Length; i++) {
			string option = resolutions[i].width + " x " + resolutions[i].height;
			options.Add(option);
			
			if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) {
				currentResIndex = i;
			}
		}

		dropdown1.AddOptions(options);

		if (js.configData.resolution == -1) {
			dropdown1.value = currentResIndex;
		}else {
			dropdown1.value = js.configData.resolution;
		}

		dropdown1.RefreshShownValue();
		Graphics_SetRes(js.configData.resolution);
	}

	public void NewGame() {
		//for now just load that scene
		SceneManager.LoadScene("MainHub");
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
		js.configData.moveSpeed = slider1.value;
		js.SaveConfig();
	}

	public void Controls_UseMouse() {
		js.configData.useMouse = toggle1.isOn;
		js.SaveConfig();
	}

	public void Controls_UseAutoFire() {
		js.configData.useAutoFire = toggle2.isOn;
		js.SaveConfig();
	}

	public void Graphics_SetFullScreen() {
		js.configData.isFullscreen = toggle3.isOn;
		js.SaveConfig();

		Screen.fullScreen = js.configData.isFullscreen;
	}

	public void Graphics_SetRes(int resIndex) {
		Resolution _resolution = resolutions[resIndex];
		Screen.SetResolution(_resolution.width, _resolution.height, js.configData.isFullscreen);

		js.configData.resolution = resIndex;
		js.SaveConfig();
	}

	public void Quit() {
		Application.Quit();
	}
}
