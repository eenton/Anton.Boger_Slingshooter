﻿using UnityEngine;
using System.Collections;

public class RyuAnimation : MonoBehaviour {

	//Animation variable
	Animator anim;
	private bool aimingMode;



	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

		}
	
	// Update is called once per frame
	void Update () {

	

		if (Input.GetMouseButtonDown(0)) {
			anim.SetBool ("MouseClick", true);

			}
			
		else {
			anim.SetBool ("MouseClick", false);

			}




	}
}
