using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckAnswer : MonoBehaviour
{

    public int LevelNumber = 1;
    public toggleBoxes tb;

    private bool isComplete = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	    if (tb.button[0].image != tb.states[0] &&
	        tb.button[1].image == tb.states[0] &&
	        tb.button[2].image != tb.states[0] &&
	        tb.button[3].image == tb.states[0] &&
	        tb.button[4].image != tb.states[0] &&
	        tb.button[5].image != tb.states[0] &&
	        tb.button[6].image == tb.states[0] &&
	        tb.button[7].image == tb.states[0] &&
	        tb.button[8].image == tb.states[0] &&
	        tb.button[9].image != tb.states[0] &&
	        tb.button[10].image != tb.states[0] &&
	        tb.button[11].image != tb.states[0] &&
	        tb.button[12].image == tb.states[0] &&
	        tb.button[13].image != tb.states[0] &&
	        tb.button[14].image != tb.states[0] &&
	        tb.button[15].image != tb.states[0] &&
	        tb.button[16].image != tb.states[0] &&
	        tb.button[17].image == tb.states[0] &&
	        tb.button[18].image != tb.states[0] &&
	        tb.button[19].image != tb.states[0] &&
	        tb.button[20].image != tb.states[0] &&
	        tb.button[21].image != tb.states[0] &&
	        tb.button[22].image == tb.states[0] &&
	        tb.button[23].image != tb.states[0] &&
	        tb.button[24].image != tb.states[0])
	    {
	        isComplete = true;
	        SceneManager.LoadScene("Success");
	    }


	}
}
