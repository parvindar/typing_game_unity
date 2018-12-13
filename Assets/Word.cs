using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

	public string word;
	private int typeindex;
	private worddisplay display;

	public Word(string _word, worddisplay _display)
	{
		word = _word;
		typeindex = 0;
		display = _display;
		display.setword (word);

	}

	public char getnextletter()
	{
		return word[typeindex];
	}

	public void TypeLetter()
	{
		typeindex++;
		//remove letter from screen.
		display.removeletter();
	}

	public bool wordtyped()
	{
		bool wordtyped=(typeindex >= word.Length);

		if (wordtyped) {
		//remove word from screen.
			display.removeword();
		}
		return wordtyped;
	}

}
