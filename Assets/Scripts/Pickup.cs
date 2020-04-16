using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
   


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
                
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    if (inventory.isFull[i] == false)
                    {
                        // item can be added to inventory



                        //Instantiate(itemButton, new Vector3(0, 0, 0), Quaternion.identity);
                        Instantiate(itemButton, inventory.slots[i].transform, false);

                        inventory.isFull[i] = true;

                        Destroy(gameObject);
                        break;


                    }


                }
            

        }

    }




}

