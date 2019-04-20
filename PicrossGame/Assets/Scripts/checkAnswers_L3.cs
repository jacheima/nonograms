using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this file checks the answers for level 3
public class checkAnswers_L3 : MonoBehaviour {


    public SpriteRenderer[] sr; //an array that holds all the sprite renders in reference to the if statement below

    public Sprite filled;// holds the sprite that the if statement checks against below


    public gameManager game; // reference to the game manager

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If this is true
        if (sr[0].sprite != filled &&
            sr[1].sprite == filled &&
            sr[2].sprite == filled &&
            sr[3].sprite == filled &&
            sr[4].sprite != filled &&
            sr[5].sprite != filled &&
            sr[6].sprite == filled &&
            sr[7].sprite != filled &&
            sr[8].sprite == filled &&
            sr[9].sprite != filled &&
            sr[10].sprite == filled &&
            sr[11].sprite == filled &&
            sr[12].sprite == filled &&
            sr[13].sprite == filled &&
            sr[14].sprite == filled &&
            sr[15].sprite == filled &&
            sr[16].sprite == filled &&
            sr[17].sprite == filled &&
            sr[18].sprite == filled &&
            sr[19].sprite == filled &&
            sr[20].sprite == filled &&
            sr[21].sprite == filled &&
            sr[22].sprite == filled &&
            sr[23].sprite == filled &&
            sr[24].sprite == filled )
        {
            //then set the level 3 bool to true in the game manager and load the success screen
            game.isL3Complete = true;
            SceneManager.LoadScene("Success");
            

        }

    }
}