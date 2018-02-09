[System.Serializable]
public class ConfigData {

	//Game
	public float moveSpeed;

	//Controls
	public bool useMouse;
	public bool useAutoFire;
	
	//Graphics
	public bool isFullscreen;
	public int resolution;
}

[System.Serializable]
public class SaveData {

	//Upgrades
	public int damageUpgradeAmount;
	public int firerateUpgradeAmount;
	public bool hasWeapon_Normal;
	public bool hasWeapon_Homing1x;
	public bool hasWeapon_Homing2x;
	public bool hasWeapon_Homing3x;
	public bool hasWeapon_Homing4x;
	public bool hasWeapon_Homing5x;
	public bool hasWeapon_Spread2x;
	public bool hasWeapon_Spread3x;
	public bool hasWeapon_Spread4x;
	public bool hasWeapon_Spread5x;
	public bool hasWeapon_Spread6x;
	public bool hasWeapon_Spread7x;

	public enum SelectedWeapon {
		Normal,
		Homing1x,
		Homing2x,
		Homing3x,
		Homing4x,
		Homing5x,
		Spread2x,
		Spread3x,
		Spread4x,
		Spread5x,
		Spread6x,
		Spread7x
	};

	public SelectedWeapon selectedWeapon;
}
