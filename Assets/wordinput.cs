using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordinput : MonoBehaviour {
	public wordmanager wordmanager;


	// Update is called once per frame
	void Update () {
		foreach (char letter in Input.inputString) {
			Debug.Log (letter);
			wordmanager.TypeLetter (letter);
		}
	}
}
