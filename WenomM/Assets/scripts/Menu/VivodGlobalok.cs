using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VivodGlobalok : MonoBehaviour {
	public Text text;
	public GameObject glob;
	// Use this for initialization
	void Start () {
		glob = GameObject.FindGameObjectWithTag ("glob");
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Прочность: " + glob.GetComponent<global> ().maxhp + "\n Энергия: " + glob.GetComponent<global> ().maxEnergy +
		"\n Обогрев: " + glob.GetComponent<global> ().maxteplo + "\n Эссенция: " + glob.GetComponent<global> ().patroni;
	}
}
