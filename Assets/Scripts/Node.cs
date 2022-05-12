using UnityEngine;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Vector3 positionOffset;

//instance data
	private GameObject turret;

	private Renderer rend;
	private Color startColor;

//makes colors stay
	void Start ()
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
    }
//changes color on click and adds to node, plays message if already turret
	void OnMouseDown ()
	{
		if (turret != null)
		{
			Debug.Log("Not Here!");
			return;
		}

		GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
		turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
	}
//makes color when hover
	void OnMouseEnter ()
	{
		rend.material.color = hoverColor;
	}
//gets rid of color
	void OnMouseExit ()
	{
		rend.material.color = startColor;
    }

}