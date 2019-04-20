using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this file exits the game when the exit button is pushed in the main menu
public class exitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Application.Quit(); //quit game
    }
}
