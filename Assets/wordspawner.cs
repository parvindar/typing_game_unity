using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordspawner : MonoBehaviour {

	public GameObject wordprefab;
	public Transform wordcanvas;
	public Vector3 Randomposition;

	public worddisplay spawnword()
	{
		
		Vector3 Randomposition = new Vector3(Random.Range (-5f, 5f), 6f);
		GameObject wordobj = Instantiate(wordprefab, Randomposition, Quaternion.identity, wordcanvas);
		worddisplay worddisplay = wordobj.GetComponent<worddisplay>();

		Debug.Log (Randomposition);
		return worddisplay;
	}
}
