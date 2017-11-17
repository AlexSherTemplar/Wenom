using UnityEngine;
using System.Collections;

public class fps : MonoBehaviour
{
	CharacterController controller;
	Animator animator;
	public float speed = 2;


	// Use this for initialization
	void Start()
	{
		controller = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		if (x != 0)
		{
			transform.Rotate(0f, x * speed, 0f);
		}

		if (z != 0)
		{
			//animator.SetBool("walk", true);
			Vector3 dir = transform.TransformDirection(new Vector3(0f, 0f, z * speed * Time.deltaTime));
			controller.Move(dir);
		}
		else
		{
			//animator.SetBool("walk", false);

		}



	}

}﻿