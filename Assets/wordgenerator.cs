using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordgenerator : MonoBehaviour {

	private static string[] wordList = {
		"laptop",
		"original",
		"sleep",
		"class",
		"yoman",
		"myself",
		"internet",
		"game",
		"computer",
		"smartphone",
		"aeroplane",
		"helicopter",
		"glucose",
		"sabun"
	};

	public static string GetRandomWord()
	{
		int randomIndex = Random.Range (0, wordList.Length);
		string randomWord = wordList [randomIndex];
		return randomWord;
	}
}
