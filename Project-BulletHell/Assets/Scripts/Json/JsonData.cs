using UnityEngine;

public class JsonData : MonoBehaviour {

	private string path;
	private string path2;

	public ConfigData configData = new ConfigData();
	public SaveData saveData = new SaveData();

	private void Awake() {
		path = Application.persistentDataPath + "/Config.json";
		path2 = Application.persistentDataPath + "/Save.json";

		//Set Defaults for Config
		if (!System.IO.File.Exists(path)) {
			Debug.LogWarning(System.Math.Round(Time.time, 2) + ": No config file found. creating config file... : " + path);

			configData.useMouse = true;
			configData.useAutoFire = true;
			configData.moveSpeed = 12.5f;

			configData.isFullscreen = true;
			configData.resolution = -1;
			configData.quality = 0;

			SaveConfig();
		} else {
			Debug.Log(System.Math.Round(Time.time, 2) + ": Config file found! : " + path);
		}
		//Set Defaults for Save
		if (!System.IO.File.Exists(path2)) {
			Debug.LogWarning(System.Math.Round(Time.time, 2) + ": No save file found. creating save file... : " + path2);

			saveData.bombCountUpgradeAmount = 0;
			saveData.damageUpgradeAmount = 0;
			saveData.firerateUpgradeAmount = 0;
			saveData.bulletSpeedUpgradeAmount = 0;

			saveData.weaponsBought = new bool[System.Enum.GetValues(typeof(SaveData.WeaponType)).Length];
			saveData.weaponsBought[0] = true;
			saveData.selectedWeapon = 0;

			SaveGame();
		} else {
			Debug.Log(System.Math.Round(Time.time, 2) + ": Save file found! : " + path2);
		}

	}

	public void SaveConfig() {
		string _contents = JsonUtility.ToJson(configData, true);
		System.IO.File.WriteAllText(path, _contents);
	}

	public void SaveGame() {
		string _contents = JsonUtility.ToJson(saveData, true);
		System.IO.File.WriteAllText(path2, _contents);
	}

	public void ReadConfig() {
		try {
			if (System.IO.File.Exists(path)) {
				string _contents = System.IO.File.ReadAllText(path);
				configData = JsonUtility.FromJson<ConfigData>(_contents);
			} else {
				Debug.LogError(System.Math.Round(Time.time, 2) + ": JsonData: Error Loading Config!");
				configData = new ConfigData();
			}
		} catch (System.Exception ex) {
			Debug.LogError(ex.Message);
		}
	}

	public void ReadSave() {
		try {
			if (System.IO.File.Exists(path2)) {
				string _contents = System.IO.File.ReadAllText(path2);
				saveData = JsonUtility.FromJson<SaveData>(_contents);
			} else {
				Debug.LogError(System.Math.Round(Time.time, 2) + ": JsonData: Error Loading Save!");
				saveData = new SaveData();
			}
		} catch (System.Exception ex) {
			Debug.LogError(ex.Message);
		}
	}
}
