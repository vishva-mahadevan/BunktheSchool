using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoosePlayer : MonoBehaviour {


	public void SivaSir()
	{
		SceneManager.LoadScene ("Scene02");
	}
	public void Senthil()
	{
		SceneManager.LoadScene ("Senthil");
	}
	public void Gilly()
	{
		SceneManager.LoadScene ("Gilbert");
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
