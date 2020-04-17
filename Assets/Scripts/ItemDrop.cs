using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDrop : MonoBehaviour
{
    public GameObject WhatItem;


  
    

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
                Debug.Log("No Flowers!");
            }
            
            if (WhatItem.name == ("StarButton"))
            {
                Debug.Log("No Sea Stars!");
            }

        }
        if ((GameObject.Find("Player").GetComponent<PlayerController3D>().PlayerColNPC2) == true)
        {
            //Debug.Log("NPC2");

            if (WhatItem.name == ("FlowerButton"))
            {

                
                Debug.Log("FLOWER THANKS!");
                


            }

            if (WhatItem.name == ("StarButton"))
            {
                Debug.Log("No Sea Stars!");
            }

        }
        if ((GameObject.Find("Player").GetComponent<PlayerController3D>().PlayerColNPC3) == true)
        {
            //Debug.Log("NPC3");

            if (WhatItem.name == ("FlowerButton"))
            {

                Debug.Log("No Flowers!");
            }

            if (WhatItem.name == ("StarButton"))
            {

                Debug.Log("SEA STAR THANKS!");
                //Heart.SetActive(true);
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


