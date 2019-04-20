using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[System.Serializable]

public class toggleBoxes : MonoBehaviour {



    public Sprite[] state;
    public int index = 0;

    public SpriteRenderer sr;
    
    

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{

	    PlayerPrefs.GetInt("Index", index);
	}

    private void OnMouseDown()
    {

        Debug.Log("User is Clicking in Box 0");

        if (index < state.Length)
        {
            index++;
            sr.sprite = state[index];
            return;

        }

        if (index >= state.Length)
        {
            index = 0;
            sr.sprite = state[index];
            return;
        }






    }

  
}
