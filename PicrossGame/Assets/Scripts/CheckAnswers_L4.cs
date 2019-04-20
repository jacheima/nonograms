using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this file checks the answers for level 4
public class CheckAnswers_L4 : MonoBehaviour {
    public SpriteRenderer[] sr; //reference to the SpriteRenderer Components listed in this Array
    public Sprite filled; // reference to the sprite that is being checked below

    public gameManager game; //reference to the game manager

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if all this is true
        if (sr[0].sprite != filled &&
            sr[1].sprite != filled &&
            sr[2].sprite != filled &&
            sr[3].sprite != filled &&
            sr[4].sprite == filled &&
            sr[5].sprite != filled &&
            sr[6].sprite != filled &&
            sr[7].sprite != filled &&
            sr[8].sprite != filled &&
            sr[9].sprite != filled &&
            sr[10].sprite != filled &&
            sr[11].sprite != filled &&
            sr[12].sprite != filled &&
            sr[13].sprite == filled &&
            sr[14].sprite == filled &&
            sr[15].sprite == filled &&
            sr[16].sprite != filled &&
            sr[17].sprite != filled &&
            sr[18].sprite != filled &&
            sr[19].sprite != filled &&
            sr[20].sprite != filled &&
            sr[21].sprite != filled &&
            sr[22].sprite != filled &&
            sr[23].sprite == filled &&
            sr[24].sprite == filled &&
            sr[25].sprite == filled &&
            sr[26].sprite != filled &&
            sr[27].sprite != filled &&
            sr[28].sprite != filled &&
            sr[29].sprite != filled &&
            sr[30].sprite == filled &&
            sr[31].sprite == filled &&
            sr[32].sprite == filled &&
            sr[33].sprite == filled &&
            sr[34].sprite == filled &&
            sr[35].sprite == filled &&
            sr[36].sprite == filled &&
            sr[37].sprite == filled &&
            sr[38].sprite == filled &&
            sr[39].sprite != filled &&
            sr[40].sprite != filled &&
            sr[41].sprite == filled &&
            sr[42].sprite == filled &&
            sr[43].sprite == filled &&
            sr[44].sprite == filled &&
            sr[45].sprite == filled &&
            sr[46].sprite == filled &&
            sr[47].sprite == filled &&
            sr[48].sprite != filled &&
            sr[49].sprite != filled &&
            sr[50].sprite != filled &&
            sr[51].sprite != filled &&
            sr[52].sprite == filled &&
            sr[53].sprite == filled &&
            sr[54].sprite == filled &&
            sr[55].sprite == filled &&
            sr[56].sprite == filled &&
            sr[57].sprite != filled &&
            sr[58].sprite != filled &&
            sr[59].sprite != filled &&
            sr[60].sprite != filled &&
            sr[61].sprite != filled &&
            sr[62].sprite == filled &&
            sr[63].sprite == filled &&
            sr[64].sprite == filled &&
            sr[65].sprite == filled &&
            sr[66].sprite == filled &&
            sr[67].sprite != filled &&
            sr[68].sprite != filled &&
            sr[69].sprite != filled &&
            sr[70].sprite != filled &&
            sr[71].sprite == filled &&
            sr[72].sprite == filled &&
            sr[73].sprite == filled &&
            sr[74].sprite != filled &&
            sr[75].sprite == filled &&
            sr[76].sprite == filled &&
            sr[77].sprite == filled &&
            sr[78].sprite != filled &&
            sr[79].sprite != filled &&
            sr[80].sprite != filled &&
            sr[81].sprite == filled &&
            sr[82].sprite == filled &&
            sr[83].sprite != filled &&
            sr[84].sprite != filled &&
            sr[85].sprite != filled &&
            sr[86].sprite == filled &&
            sr[87].sprite == filled &&
            sr[88].sprite != filled &&
            sr[89].sprite != filled &&
            sr[90].sprite != filled &&
            sr[91].sprite != filled &&
            sr[92].sprite != filled &&
            sr[93].sprite != filled &&
            sr[94].sprite != filled &&
            sr[95].sprite != filled &&
            sr[96].sprite != filled &&
            sr[97].sprite != filled &&
            sr[98].sprite != filled &&
            sr[99].sprite != filled)
        {
            //then set the level 4 bool in the game manager to true and load the success screen
            game.isL4Complete = true;
            SceneManager.LoadScene("Updates");
            
        }

    }
}