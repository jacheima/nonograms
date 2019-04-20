using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public bool isL1Complete = false;
    public bool isL2Complete = false;
    public bool isL3Complete = false;
    public bool isL4Complete = false;

    public SpriteRenderer[] sr;

    public Sprite l1c;
    public Sprite l2c;
    public Sprite l3c;
    public Sprite l4c;


    private static gameManager instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

	// Use this for initialization
	void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {

	    if (isL1Complete == true)
	    {
	        sr[0].sprite = l1c;
	    }

	    if (isL2Complete == true)
	    {
	        sr[1].sprite = l2c;
	    }

	    if (isL3Complete == true)
	    {
	        sr[2].sprite = l3c;
	    }

	    if (isL4Complete == true)
	    {
	        sr[3].sprite = l4c;
	    }
		
	}
}
