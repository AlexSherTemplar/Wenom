using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global : MonoBehaviour {
	//основные переменные
	public int money,maxhp,maxEnergy,maxteplo,patroni;
	//робот
	public int fstW, secW,osn,plata;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void MaxHP(int ims){
		maxhp =ims;
	}
	public void MaxEnergy(int ism){
		maxEnergy = ism;
	}
	public void MaxTeplo(int ism){
		maxteplo = ism;
	}
	public void fstWeap(int ism){
		fstW = ism;
	}
	public void SecWeap(int ism){
		secW = ism;
	}
	public void Osnova(int ism){
		osn = ism;
	}
	public void Plata(int ism){
		plata = ism;
	}
	public void Patroni(int ism){
		patroni += ism;
	}
}
