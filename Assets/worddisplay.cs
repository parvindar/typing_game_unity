using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class worddisplay : MonoBehaviour {

	public Text text;


	public void setword(string word)
	{
		text.text = word;
	
	}

	public void removeletter()
	{
		text.text = text.text.Remove (0, 1);
		text.color = Color.red;
	}
	public void removeword()
	{
		Destroy (gameObject);
	}
}
