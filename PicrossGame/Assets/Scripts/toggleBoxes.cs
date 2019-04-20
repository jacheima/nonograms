using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleBoxes : MonoBehaviour {

    public Sprite empty;
    public Sprite filled;
    public Sprite xedOut;

    public SpriteRenderer sr;
    

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if(sr.sprite == empty)
        {
            sr.sprite = filled;
            return;
        }

        if (sr.sprite == filled)
        {
            sr.sprite = xedOut;
            return;
        }

        if(sr.sprite == xedOut)
        {
            sr.sprite = empty;
            return;
        }


    }
}
