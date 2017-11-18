using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMenu : MonoBehaviour {
	public int menu=0;
	public Transform[] Menu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		for (int i = 0; i < Menu.Length; i++) {
			
				Menu [menu].gameObject.SetActive (true);
			
				for(int r=0;r<menu;r++){
					Menu [r].gameObject.SetActive (false);
				}
				for(int r=menu+1;r<Menu.Length;r++){
					Menu [r].gameObject.SetActive (false);

			}

		}

	}
	public void SetValue(int val){
		menu = val;
	}

}

