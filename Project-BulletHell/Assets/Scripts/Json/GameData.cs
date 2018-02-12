using System.Collections.Generic;

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
	public int quality;
}

[System.Serializable]
public class SaveData {

	//Upgrades
	public int bombCountUpgradeAmount;
	public int damageUpgradeAmount;
	public int firerateUpgradeAmount;

	public bool[] weaponsBought;
	public int selectedWeapon;

	public enum WeaponType {
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
}
