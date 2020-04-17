using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDrop : MonoBehaviour
{
    public GameObject WhatItem;

    public GameObject Heart;
    

    void Start()
    {


    }


    public void DropItem()
    {
        //(GameObject.Find("Player").GetComponent<PlayerController3D>().PlayerColNPC1);

        if ((GameObject.Find("Player").GetComponent<PlayerController3D>().PlayerColNPC1) == true)
        {
            //Debug.Log("NPC1");

            if (WhatItem.name == ("FlowerButton"))
            {
                
                Debug.Log("Flower WTF");
            }
            
            if (WhatItem.name == ("StarButton"))
            {
                Debug.Log("Star WTF");
            }

        }
        if ((GameObject.Find("Player").GetComponent<PlayerController3D>().PlayerColNPC2) == true)
        {
            //Debug.Log("NPC2");

            if (WhatItem.name == ("FlowerButton"))
            {

                Debug.Log("WOW FLOWER THANKS!");
                Heart.SetActive(true);
            }

            if (WhatItem.name == ("StarButton"))
            {
                Debug.Log("Star WTF");
            }

        }
        if ((GameObject.Find("Player").GetComponent<PlayerController3D>().PlayerColNPC3) == true)
        {
            //Debug.Log("NPC3");

            if (WhatItem.name == ("FlowerButton"))
            {

                Debug.Log("Flower WTF");
            }

            if (WhatItem.name == ("StarButton"))
            {
                Debug.Log("Star OMG THANKS");
                Heart.SetActive(true);
            }

        }


    }

        

    
    /*
    
    void OnEnable()
    {

        myButton.onClick.AddListener(MyFunction);//adds a listener for when you click the button


    }
    void MyFunction()// your listener calls this function
    {
        Debug.Log("Painoit Nappia");


    }
    */
}


