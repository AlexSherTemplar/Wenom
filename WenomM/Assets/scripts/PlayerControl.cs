﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class PlayerControl : MonoBehaviour {

	public float speed = 1.5f;



	public KeyCode jumpButton = KeyCode.Space; // клавиша для прыжка
	public float jumpForce = 10; // сила прыжка
	public float jumpDistance = 1.2f; // расстояние от центра объекта, до поверхности

	private Vector3 direction;
	private float h, v;
	private int layerMask;
	private Rigidbody body;


	void Start () 
	{
		body = GetComponent<Rigidbody>();
		body.freezeRotation = true;
		layerMask = 1 << gameObject.layer | 1 << 2;
		layerMask = ~layerMask;
	}

	void FixedUpdate()
	{
		body.AddForce(speed*transform.forward, ForceMode.Force);

		// Ограничение скорости, иначе объект будет постоянно ускоряться
		if(Mathf.Abs(body.velocity.x) > speed)
		{
			body.velocity = new Vector3(Mathf.Sign(body.velocity.x) * speed, body.velocity.y, body.velocity.z);
		}
		if(Mathf.Abs(body.velocity.z) > speed)
		{
			body.velocity = new Vector3(body.velocity.x, body.velocity.y, Mathf.Sign(body.velocity.z) * speed);
		}
	}

	bool GetJump() // проверяем, есть ли коллайдер под ногами
	{
		RaycastHit hit;
		Ray ray = new Ray(transform.position, Vector3.down);
		if (Physics.Raycast(ray, out hit, jumpDistance, layerMask))
		{
			return true;
		}

		return false;
	}

	void Update () 
	{
		h = Input.GetAxis("Horizontal");
		v = Input.GetAxis("Vertical");



		// вектор направления движения
		direction = new Vector3(h, 0, v);
		transform.Rotate(0f, h * speed, 0f);
		direction = new Vector3(direction.x, 0, direction.z);

		if(Input.GetKeyDown(jumpButton) && GetJump())
		{
			body.velocity = new Vector2(0, jumpForce);
		}
	}

	void OnDrawGizmosSelected() // подсветка, для визуальной настройки jumpDistance
	{
		Gizmos.color = Color.red;
		Gizmos.DrawRay(transform.position, Vector3.down * jumpDistance);
	}
}