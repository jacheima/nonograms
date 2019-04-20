using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this file is the game manager
public class gameManager : MonoBehaviour
{

    public bool isL1Complete = false; //tells us if the level has already been completed
    public bool isL2Complete = false; //tells us if the level has already been completed
    public bool isL3Complete = false; //tells us if the level has already been completed
    public bool isL4Complete = false; //tells us if the level has already been completed


    public GameObject wrench; //reference to the wrench game object
    public GameObject bolt; //reference to the bolt game object
    public GameObject toolKit; //reference to the toolKit game object
    public GameObject star; // reference to the star game object


    private static gameManager instance; //set the game manager to instance

    void Awake()
    {
        //if the instance does not equal null and it does not equal this file 
        if (instance != null && instance != this)
        {
            //then destroy this game object
            Destroy(this.gameObject);
            return; //exit
        }
        else //otherwise
        {
            //set instance to this
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject); //don't destroy the object when a new scene loads
    }

    // Use this for initialization
    void Start()
    {
        //setting the game objects to false so they won't show up in the screen until a condition is met
        wrench.SetActive(false); 
        bolt.SetActive(false);
        toolKit.SetActive(false);
        star.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if level one is complete
        if (isL1Complete == true)
        {
            //then set the wrench to true
            wrench.SetActive(true);

        }

        //if level 2 is complete
        if (isL2Complete == true)
        {
            //then set the bolt to true
            bolt.SetActive(true);

        }

        //if level 3 is complete
        if (isL3Complete == true)
        {
            //then set the tool kit to true
            toolKit.SetActive(true);

        }

        //if level 4 is complete 
        if (isL4Complete == true)
        {
            //then set the star to true
            star.SetActive(true);
        }

    }
}