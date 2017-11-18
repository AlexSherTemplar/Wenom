using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonQuest : MonoBehaviour {
	public string[] scenes;
	public string[] opis;
	public string[] names;
	public string[] soveti;

	public int scena;
	public string sovt;

	public GameObject text;
	public GameObject nameB;

	void Start () {
		scena = Random.Range (0, scenes.Length);
		text.GetComponent<Text> ().text = opis [scena];
		nameB.GetComponent<Text> ().text = names [scena];
		sovt = soveti [scena];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Perechod(){
		SceneManager.LoadScene (scenes [scena]);
	}
}
