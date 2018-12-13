using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordmanager : MonoBehaviour {

	public List<Word> words;
	private bool  hasactiveword;
	private Word activeword;
	public wordspawner wordspawner;
		
	private void Start()
	{
		AddWord ();
		AddWord ();
		AddWord ();
	}

	public void AddWord()
	{
		
		Word word =new Word(wordgenerator.GetRandomWord(),wordspawner.spawnword());
		Debug.Log (word.word);
		words.Add (word);
	}

	public void TypeLetter(char letter)
	{
		if (hasactiveword) {
			//check if letter was next
			if (activeword.getnextletter () == letter) {
				activeword.TypeLetter ();
			}
			// then remove it from screen
		}
		else {
			foreach (Word word in words) {
				if (word.getnextletter () == letter) {
					activeword = word;
					hasactiveword = true;
					word.TypeLetter ();
					break;
				}
			}
		
		}
		if (hasactiveword && activeword.wordtyped ()) {
		
			hasactiveword = false;
			words.Remove (activeword);
		}
	}
}
