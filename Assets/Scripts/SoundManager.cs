using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour 
{
	public static AudioClip jumpsound,deathsound,BGMSound;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start ()
	{
		deathsound = Resources.Load<AudioClip> ("Death");
		jumpsound = Resources.Load<AudioClip> ("Jump");
		BGMSound = Resources.Load<AudioClip> ("BGM");

		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static void PlaySound(string clip)
	{
		switch (clip) 
		{
		case "Death":
			audioSrc.PlayOneShot (deathsound);
			break;
		case "Jump":
			audioSrc.PlayOneShot (jumpsound);
			break;
		case "BGM":
			audioSrc.PlayOneShot(BGMSound);
			break;

		}
	}
}
