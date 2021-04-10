using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Airplane : MonoBehaviour {

	[SerializeField]
	float moveSpeed = 15f;

	[SerializeField]
	float angularSpeed = 2f;

	float rotationX;

	Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update()
	{
		rotationX = CrossPlatformInputManager.GetAxis ("Horizontal");
		transform.Rotate(0, 0, rotationX * angularSpeed);
	}		

	void FixedUpdate () {
		rb.velocity = transform.up * moveSpeed;
	}

}
