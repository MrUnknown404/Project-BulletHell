using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class HubMenu : MonoBehaviour {

	[SerializeField]
	private Dropdown selectedWeapon;

	private JsonData js;

	private void Start() {
		js = GameObject.Find("_GameManager").GetComponent<JsonData>();
		if (js == null) {
			Debug.LogError(System.Math.Round(Time.time, 2) + ": PlayerCtrl: Cannot Find _GameManager (Probably switched scenes incorrectly)");
		}
		js.ReadSave();
		
		List<string> _options = new List<string>();
		for (int i = 0; i < js.saveData.weaponsBought.Length; i++) {
			if (js.saveData.weaponsBought[i] != false) {
				SaveData.WeaponType _value = (SaveData.WeaponType)i;
				_options.Add(_value.ToString());
			} else {
				_options.Add("Null");
			}
		}

		selectedWeapon.ClearOptions();
		selectedWeapon.AddOptions(_options);
		selectedWeapon.RefreshShownValue();

		SelectedWeapon(js.saveData.selectedWeapon);
	}

	public void SelectedWeapon(int i) {
		if (js.saveData.weaponsBought[i] == true) {
			selectedWeapon.value = i;
			js.saveData.selectedWeapon = i;
		} else {
			selectedWeapon.value = 0;
			js.saveData.selectedWeapon = 0;
		}
		selectedWeapon.RefreshShownValue();
		js.SaveGame();
	}

	public void QuitToMenu() {
		SceneManager.LoadScene("MainMenu");
	}

	public void TempLoadLevel() {
		//temp
		SceneManager.LoadScene("Debug");
	}
}
