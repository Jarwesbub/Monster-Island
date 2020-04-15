using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NPCcollision : MonoBehaviour
{


    public GameObject FloatingTextPrefab;

    private int Check = 0;

    private bool Talk = false;
  

    
    void OnTriggerEnter (Collider other)
    {
        Check = 2; //Hello

    }
    void OnTriggerExit(Collider other)
    {

        Check = 1; //BYE

    }

    void OnCollisionEnter(Collision collision)
    {
        Check = 3; //??

    }

    void ShowFloatingText()
    {
        if (FloatingTextPrefab != null)
        {
            var text = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
            text.GetComponent<TextMesh>().text = "Hello!";
        }       
    }
    private IEnumerator TalkingTime()
    {

        yield return new WaitForSeconds(2f);


        //Destroy(FloatingTextPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (FloatingTextPrefab != null && Check == 2 && Talk == false)
        {
            var text = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
            text.GetComponent<TextMesh>().text = "Hello!";
            Talk = true;

            //StartCoroutine(TalkingTime());
            
            Destroy(text,1);
            
              
            
       }


        if (FloatingTextPrefab != null && Check == 1 && Talk == false)
        {
            var text = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
            text.GetComponent<TextMesh>().text = "Bye!";
            Talk = true;

            StartCoroutine(TalkingTime());


        }




    }
}
