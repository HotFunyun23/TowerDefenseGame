using UnityEngine;

public class Bullet : MonoBehaviour {

	private Transform target;

//instance
	public float speed = 70f;
	public GameObject impactEffect;

//sets target
	public void Seek (Transform _target)
	{
		target = _target;
	}

	// Update is called once per frame
	void Update () {
//kills bullet if no target
		if (target == null)
		{
			Destroy(gameObject);
			return;
		}
//moves it
		Vector3 dir = target.position - transform.position;
		float distanceThisFrame = speed * Time.deltaTime;

		if (dir.magnitude <= distanceThisFrame)
		{
			HitTarget();
			return;
		}

		transform.Translate(dir.normalized * distanceThisFrame, Space.World);

	}
//if hits then destroys both
	void HitTarget ()
	{
		GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
		Destroy(effectIns, 2f);

		Destroy(target.gameObject);
		Destroy(gameObject);
	}
}