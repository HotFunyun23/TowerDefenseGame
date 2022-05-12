using UnityEngine;
using System.Collections;
public class Turret : MonoBehaviour {

	private Transform target;

	[Header("Attributes")]

	public float range = 15f;
	public float fireRate = 1f;
	private float fireCountdown = 0f;

	[Header("Unity Setup Fields")]

	public string enemyTag = "Enemy";
//sets speed and part to move
	public Transform partToRotate;
	public float turnSpeed = 10f;

	public GameObject bulletPrefab;
	public Transform firePoint;

	  // starts and calls 2 times per second
	void Start () {
		InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}
//searches through all marked objects and finds closest in range and sets target
	void UpdateTarget ()
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);//finds closest and sets to enemies
		float shortestDistance = Mathf.Infinity; //stores closest enemy
		GameObject nearestEnemy = null;
		foreach (GameObject enemy in enemies)//searches through game objects with enemy tag

		{
			float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);//sets float to the distance between turret and enemy
			if (distanceToEnemy < shortestDistance)
			{
				shortestDistance = distanceToEnemy;
				nearestEnemy = enemy;
			}
		}
		if (nearestEnemy != null && shortestDistance <= range)//if finds enemy in range

		{
			target = nearestEnemy.transform;//sets target
		} else
		{
			target = null;
		}
	}
	// Update is called once per frame
	void Update () {
		if (target == null)
			return;
		//Target lock on
		Vector3 dir = target.position - transform.position;
		Quaternion lookRotation = Quaternion.LookRotation(dir);
		Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
		partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);

		if (fireCountdown <= 0f)
		{    //fire rate
			Shoot();
			fireCountdown = 1f / fireRate;
		}

		fireCountdown -= Time.deltaTime;

	}

	void Shoot ()
	{
		GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		Bullet bullet = bulletGO.GetComponent<Bullet>();

		if (bullet != null)
			bullet.Seek(target);
	}

	//makes sure only wires to enemies for turret range display

	void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red; //makes range red
		Gizmos.DrawWireSphere(transform.position, range); //shows range based on player
	}
}