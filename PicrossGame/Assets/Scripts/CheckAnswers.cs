using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This file checks to see if the boxes are filled in correctly for level 1
public class CheckAnswers : MonoBehaviour {

    public SpriteRenderer[] sr; //Holds all the SpriteRenderers

    public Sprite filled; // holds the sprite for filled as a reference


    public gameManager game; // reference to gameManager

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //every frame it checks to see if this if statement is true
		if(sr[0].sprite != filled &&
           sr[1].sprite == filled &&
           sr[2].sprite != filled &&
           sr[3].sprite == filled &&
           sr[4].sprite != filled &&
           sr[5].sprite != filled &&
           sr[6].sprite == filled &&
           sr[7].sprite == filled &&
           sr[8].sprite == filled &&
           sr[9].sprite != filled &&
           sr[10].sprite != filled &&
           sr[11].sprite != filled &&
           sr[12].sprite == filled &&
           sr[13].sprite != filled &&
           sr[14].sprite != filled &&
           sr[15].sprite != filled &&
           sr[16].sprite != filled &&
           sr[17].sprite == filled &&
           sr[18].sprite != filled &&
           sr[19].sprite != filled &&
           sr[20].sprite != filled &&
           sr[21].sprite != filled &&
           sr[22].sprite == filled &&
           sr[23].sprite != filled &&
           sr[24].sprite != filled )
		{
            //if it is it sets the level 1 complete bool in the game manager to true and loads the success screen
		    game.isL1Complete = true;
            SceneManager.LoadScene("Success");
		    
        }

    }
}
