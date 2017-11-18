using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sovet : MonoBehaviour {
	public GameObject text;
	public GameObject glob;
	public GameObject but;

	void Start(){
		glob = GameObject.FindGameObjectWithTag ("glob");
	}
	public void Sov(){
		if (glob.GetComponent<global> ().money >= 200) {
			glob.GetComponent<global> ().money -= 200;
			text.GetComponent<Text> ().text = but.GetComponent<buttonQuest> ().sovt;
			Destroy (gameObject);
		}
	}
}
