using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMarker : MonoBehaviour
{

    public bool IsColoredChecked = true;
    public bool IsXChecked = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UseColored()
    {
        IsColoredChecked = true;
        IsXChecked = false;
    }

    public void UseXs()
    {
        IsColoredChecked = false;
        IsXChecked = true;
    }
}
