using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterToMainMenu : MonoBehaviour {

	public void Exit()
	{
		SceneManager.LoadScene ("Scene03");
	}
}
