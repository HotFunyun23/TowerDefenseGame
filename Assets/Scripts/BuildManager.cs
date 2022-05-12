using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;
//starts manager and makes sure is only 1 instance
	void Awake ()
	{
		if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}

	public GameObject standardTurretPrefab;

//Lets place standard on nodes
	void Start ()
	{
		turretToBuild = standardTurretPrefab;
	}

	private GameObject turretToBuild;

	public GameObject GetTurretToBuild ()
	{
		return turretToBuild;
	}

}