using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanBeDestroyed : MonoBehaviour {
	public Transform destroyed;

	public void Dead(){
		Instantiate (destroyed, transform.position,Quaternion.Euler(transform.rotation.x+90,transform.rotation.y,transform.rotation.z));
		Destroy (gameObject);
	}
}
