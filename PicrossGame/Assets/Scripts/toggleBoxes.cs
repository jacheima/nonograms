using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//this file changes the boxes when you click in them

public class toggleBoxes : MonoBehaviour {



    public Sprite[] state; //hold all possible box state, empty, filled, or ex-ed out
    public int index = 0; // holds the index of the button

    public SpriteRenderer sr; //reference to the sprite renderer
    
    

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{

	    PlayerPrefs.GetInt("Index", index); //saves the index of the box so the player can stop and return to the game
	}

    private void OnMouseDown()
    {

        Debug.Log("User is Clicking in Box 0"); //Debug

        if (index < state.Length) // if the index is less than the length of the state array
        {
            index++;//then increment the index
            sr.sprite = state[index];//change the sprite to the sprite at that index
            return;//and exit

        }

        if (index >= state.Length) // if the index is greater than or equal to the length of the state array
        {
            index = 0; //set index to 0
            sr.sprite = state[index]; // change the sprite to the sprite at that index
            return; // and exit
        }






    }

  
}
