﻿using UnityEngine;
using System.Collections;

public class QuestTwoADeadBody : MonoBehaviour {

	public QuestController controller;
	public bool enter;


	// Use this for initialization
	void Start () {
		enter = false;	
	}

	// Update is called once per frame
	void Update () {
		

	}

	void OnGUI(){
		if (enter) {
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 150, 30), "A dead body...");
		}

	}


	void OnTriggerEnter (Collider other ){
		if (other.gameObject.tag == "Player") {
			enter = true;
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Player") {
			enter = false;
		}
	}
}
