using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VivodMoney : MonoBehaviour {
	public Text text;
	public GameObject glob;

	void Start () {
		glob = GameObject.FindGameObjectWithTag ("glob");
	}
	

	void Update () {
		text.text ="Money: "+glob.GetComponent<global> ().money.ToString();
	}
}
