using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public static GameControl instance = null;

	[SerializeField]
	GameObject restartButton;

	[SerializeField]
	GameObject ExitButton;

	[SerializeField]
	GameObject GameOverInfo;

	[SerializeField]
	GameObject UpButtoninfo;


	[SerializeField]
	Text highScoreText;

	[SerializeField]
	Text yourScoreText;

	[SerializeField]
	GameObject[] obstacles;

	[SerializeField]
	Transform spawnPoint;

	[SerializeField]
	float spawnRate = 2f;
	float nextSpawn;

	[SerializeField]
	float timeToBoost = 5f;
	float nextBoost;

	int highScore = 0, yourScore = 0;

	public static bool gameStopped;

	float nextScoreIncrease = 0f;

	// Use this for initialization
	void Start () {

		if (instance == null) 
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		UpButtoninfo.SetActive (true);
		restartButton.SetActive (false);
		ExitButton.SetActive (false);
		GameOverInfo.SetActive (false);

		yourScore = 0;
		gameStopped = false;
		Time.timeScale = 1f;
		highScore = PlayerPrefs.GetInt ("highScore");
		nextSpawn = Time.time + spawnRate;
		nextBoost = Time.unscaledTime + timeToBoost;
	}

	// Update is called once per frame
	void Update () {
		if (!gameStopped)
			IncreaseYourScore ();

		highScoreText.text = "Highest Run to PT: " + highScore;
		yourScoreText.text = "Your Running: " + yourScore;

		if (Time.time > nextSpawn)
			SpawnObstacle ();

		if (Time.unscaledTime > nextBoost && !gameStopped)
			BoostTime ();
	}

	public void DinoHit()
	{
		if (yourScore > highScore)
			PlayerPrefs.SetInt("highScore", yourScore);
		Time.timeScale = 0;
		gameStopped = true;
		SoundManager.PlaySound ("Death");
		restartButton.SetActive (true);
		ExitButton.SetActive (true);
		GameOverInfo.SetActive (true);
		UpButtoninfo.SetActive (false);

	}

	void SpawnObstacle()
	{
		nextSpawn = Time.time + spawnRate;
		int randomObstacle = Random.Range (0, obstacles.Length);
		Instantiate (obstacles [randomObstacle], spawnPoint.position, Quaternion.identity);
	}

	void BoostTime()
	{
		nextBoost = Time.unscaledTime + timeToBoost;
		Time.timeScale += 0.25f;
	}

	void IncreaseYourScore()
	{
		if (Time.unscaledTime > nextScoreIncrease) {
			yourScore += 1;
			nextScoreIncrease = Time.unscaledTime + 1;
		}
	}

	public void RestartGame()
	{
		SceneManager.LoadScene ("Scene02");
	}

	public void Exit()
	{
		SceneManager.LoadScene("Scene03");
	}
}
