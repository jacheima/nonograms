using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this file checks the answers for level 2

public class CheckAnswers_L2 : MonoBehaviour {

    public SpriteRenderer[] sr; //an array that holds the sprite renderers that are used in reference to this script
    public Sprite filled; // reference to the filled sprite that is a condition for the if statement below

    public gameManager game;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if all of this is tru
        if (sr[0].sprite != filled && //the sprite renderer is not equal to the sprite filled
            sr[1].sprite == filled && // the sprite renderer is equal to the sprite filled
            sr[2].sprite == filled &&
            sr[3].sprite == filled &&
            sr[4].sprite != filled &&
            sr[5].sprite == filled &&
            sr[6].sprite == filled &&
            sr[7].sprite == filled &&
            sr[8].sprite == filled &&
            sr[9].sprite == filled &&
            sr[10].sprite == filled &&
            sr[11].sprite == filled &&
            sr[12].sprite != filled &&
            sr[13].sprite == filled &&
            sr[14].sprite == filled &&
            sr[15].sprite == filled &&
            sr[16].sprite == filled &&
            sr[17].sprite == filled &&
            sr[18].sprite == filled &&
            sr[19].sprite == filled &&
            sr[20].sprite != filled &&
            sr[21].sprite == filled &&
            sr[22].sprite == filled &&
            sr[23].sprite == filled &&
            sr[24].sprite != filled)
        {
            //then set the level 2 bool to true in the game manager and load the success screen
            game.isL2Complete = true;
            SceneManager.LoadScene("Success");
            
        }

    }
}
