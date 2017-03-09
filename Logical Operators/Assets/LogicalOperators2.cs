using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators2 : MonoBehaviour {

public string numbers1;
public string numbers2;

public void OnButtonClick () {
		if(numbers1 == "1" && numbers2 == "2")
		{
			print("One and Two are here.");
		}
		if(numbers1 == "1" || numbers2 == "2")
		{
			print("One or Two is here.");
		}
		if(numbers1 != "1" && numbers2 != "2");
		{
			print("No one is here.");
		}
	}
}
