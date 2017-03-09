using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeandAccess : MonoBehaviour {
	//Access Modifiers are what defines how an object will be seen.
	//We've only learned two in class, though the book defines more. What we've learned includes:
	//Private and Public. Public means we can see it Unity, Private is within the script only.

	public List<string> myCats; //we can all see this!
	private List<int> myCatsHealth; //we can't see this in Unity, however, and so we cannot edit it there

	// Use this for initialization
	public void Start () {
		//Scope is the area where something is contained, like this function.
		myCats.Add("Mr. Peanut Butter");
		myCats.Add("Lucy");
		myCats.Add("Garfield");
		myCats.Remove("Garfield");
	}
	//Scope and Access is essentially what we've been doing the entire class. It's just the containment of things and how we can access them.
	//Access should be considered carefully, however. You never know who you want to be able to touch your variables or functions.
	// Update is called once per frame
	void Update () {
		
	}
}
