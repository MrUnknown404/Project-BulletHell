using UnityEngine;

public class JsonData : MonoBehaviour {

	private string path;

	public GameData gameData = new GameData();

	private void Awake() {
		path = Application.persistentDataPath + "/Config.json";
		//Set Defaults
		if (!System.IO.File.Exists(path)) {
			Debug.Log(System.Math.Round(Time.time, 2) + ": No config file found. creating config file...");
			gameData.useMouse = true;
			gameData.useAutoFire = true;
			SaveConfig();
		} else {
			Debug.Log(System.Math.Round(Time.time, 2) + ": Config file found!");
		}
	}

	public void SaveConfig() {
		string contents = JsonUtility.ToJson(gameData);
		System.IO.File.WriteAllText(path, contents);
	}

	public void ReadConfig() {
		try {
			if (System.IO.File.Exists(path)) {
				string contents = System.IO.File.ReadAllText(path);
				gameData = JsonUtility.FromJson<GameData>(contents);
			} else {
				Debug.LogError(System.Math.Round(Time.time, 2) + ": JsonData: Error Loading Config!");
				gameData = new GameData();
			}
		} catch (System.Exception ex) {
			Debug.LogError(ex.Message);
		}
	}
}
