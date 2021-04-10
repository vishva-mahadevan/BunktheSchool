using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene("ChoosePlayer");
	}

	public void OptionsMenu()
	{
		SceneManager.LoadScene("Scene04");
	}

	public void QuitGame () {

		#if !UNITY_EDITOR
		Application.Quit();
		#endif

		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}
}
