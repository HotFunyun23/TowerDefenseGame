/**
Wave Controller
 Controls waves and changes timer and enemies spawn
 Author: Conor
 Colab: brackeys tutorial
 Date: 12/17/21
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave_Controller : MonoBehaviour{

/** instance data **/
	public Transform enemyPrefab;

	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	public Text waveCountdownText;

	private int waveIndex = 0;

/** checks time and updates text, next wave, etc. **/
	void Update ()
	{
		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;

		waveCountdownText.text = Mathf.Round(countdown).ToString();
	}

/** spawns wave of enemy prefabs after eachother **/
	IEnumerator SpawnWave ()
	{
		waveIndex++;

		for (int i = 0; i < waveIndex; i++)
		{
			SpawnEnemy();
			yield return new WaitForSeconds(0.5f);
		}
	}

/** actually spawns enemy prefab **/
	void SpawnEnemy ()
	{
		Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
	}

}
