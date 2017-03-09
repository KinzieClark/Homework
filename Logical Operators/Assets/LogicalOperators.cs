using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

public string string1;
public string string2;

// && is the and operator
// || is the or operator
// ! is the not operator
	// Use this for initialization
	public void OnButtonClick () {
		if(string1 == "Thing1" && string2 == "Thing2")
		{
			print("These Things are quite tame, oh so tame.");
		}
		if(string1 == "Thing1" || string2 == "Thing2")
		{
			print("It's fun to have fun if you know what to do.");
		}
		if(string1 != "Thing1" && string2 != "Thing2");
		{
			print("Oh what a shame, what a shame, what a shame.");
		}
}
}