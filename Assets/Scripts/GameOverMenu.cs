using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
	public GameControl Gamer;

	public Text scoretext; 
	public void RestartGame()
	{
		SceneManager.LoadScene ("Scene02");
	}

	public void Exit()
	{
		SceneManager.LoadScene ("Scene03");
	}

	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		
	}

	public void  ToggleEndMenu(int scr)
	{
		scoretext.text = "Your Score: " + scr;
	}
}
