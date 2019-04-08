using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleBoxes : MonoBehaviour
{

    public Button[] button;

    public Sprite[] states;

    private int index = 0;
    private int ButtonIndex = 0;

    public ToggleMarker tm;



    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (button[0].image.sprite == states[0])
        {
            button[0].image.sprite = states[1];
            button[0].onClick.RemoveAllListeners();
        }
        if (button[1].image.sprite == states[0])
        {
            button[1].onClick.RemoveAllListeners();
        }
        if (button[2].image.sprite == states[0])
        {
            button[2].image.sprite = states[1];
            button[2].onClick.RemoveAllListeners();
        }
        if (button[3].image.sprite == states[0])
        {
            button[3].onClick.RemoveAllListeners();
        }
        if (button[4].image.sprite == states[0])
        {
            button[4].image.sprite = states[1];
            button[4].onClick.RemoveAllListeners();
        }
        if (button[5].image.sprite == states[0])
        {
            button[5].image.sprite = states[1];
            button[5].onClick.RemoveAllListeners();
        }
        if (button[6].image.sprite == states[0])
        {
            button[6].onClick.RemoveAllListeners();
        }
        if (button[7].image.sprite == states[0])
        {
            button[7].onClick.RemoveAllListeners();
        }
        if (button[8].image.sprite == states[0])
        {
            button[8].onClick.RemoveAllListeners();
        }
        if (button[9].image.sprite == states[0])
        {
            button[9].image.sprite = states[1];
            button[9].onClick.RemoveAllListeners();
        }
        if (button[10].image.sprite == states[0])
        {
            button[10].image.sprite = states[1];
            button[10].onClick.RemoveAllListeners();
        }
        if (button[11].image.sprite == states[0])
        {
            button[11].image.sprite = states[1];
            button[11].onClick.RemoveAllListeners();
        }
        if (button[12].image.sprite == states[0])
        {
            button[12].onClick.RemoveAllListeners();
        }
        if (button[13].image.sprite == states[0])
        {
            button[13].image.sprite = states[1];
            button[13].onClick.RemoveAllListeners();
        }
        if (button[14].image.sprite == states[0])
        {
            button[14].image.sprite = states[1];
            button[14].onClick.RemoveAllListeners();
        }
        if (button[15].image.sprite == states[0])
        {
            button[15].image.sprite = states[1];
            button[15].onClick.RemoveAllListeners();
        }
        if (button[16].image.sprite == states[0])
        {
            button[16].image.sprite = states[1];
            button[16].onClick.RemoveAllListeners();
        }
        if (button[17].image.sprite == states[0])
        {
            button[17].onClick.RemoveAllListeners();
        }
        if (button[18].image.sprite == states[0])
        {
            button[18].image.sprite = states[1];
            button[18].onClick.RemoveAllListeners();
        }
        if (button[19].image.sprite == states[0])
        {
            button[19].image.sprite = states[1];
            button[19].onClick.RemoveAllListeners();
        }
        if (button[20].image.sprite == states[0])
        {
            button[20].image.sprite = states[1];
            button[20].onClick.RemoveAllListeners();
        }
        if (button[21].image.sprite == states[0])
        {
            button[21].image.sprite = states[1];
            button[21].onClick.RemoveAllListeners();
        }
        if (button[22].image.sprite == states[0])
        {
            button[22].onClick.RemoveAllListeners();
        }
        if (button[23].image.sprite == states[0])
        {
            button[23].image.sprite = states[1];
            button[23].onClick.RemoveAllListeners();
        }
        if (button[24].image.sprite == states[0])
        {
            button[24].image.sprite = states[1];
            button[24].onClick.RemoveAllListeners();
        }
    }

    public void changeImage(int i)
    {
        if (tm.IsColoredChecked == true && tm.IsXChecked == false)
        {
            index = 0;
            
        }
        else if (tm.IsColoredChecked == false && tm.IsXChecked == true)
        {
            index = 1;
        }

        button[i].image.sprite = states[index];

        

    }

    void checkLevelOne()
    {
       
    }
}
   
