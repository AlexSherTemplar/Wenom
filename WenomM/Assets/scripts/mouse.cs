using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;



public class mouse: MonoBehaviour
	{
	public Transform head;

	public float sensitivity = 5f; // чувствительность мыши
	public float headMinY = -40f; // ограничение угла для головы
	public float headMaxY = 40f;
	private float rotationY;

	void Update(){
		// управление головой (камерой)
		float rotationX = head.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
		rotationY += Input.GetAxis("Mouse Y") * sensitivity;
		rotationY = Mathf.Clamp (rotationY, headMinY, headMaxY);
		head.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
	}
	}

