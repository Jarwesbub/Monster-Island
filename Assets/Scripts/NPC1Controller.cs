using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1Controller : MonoBehaviour
{
    // Collision trigger for Dialogue
    public GameObject NPC1;
    // Full dialogue active or not
    public GameObject NPC1Dialogue;
    // Talk button
    public GameObject NPC1TalkButton;
    // Dialogue and continue button
    public GameObject NPC1DialogueBox;


    void Start()
    {
        NPC1TalkButton.SetActive(false);
        NPC1DialogueBox.SetActive(false);
    }

    void OnTriggerEnter (Collider other)
    {
        NPC1TalkButton.SetActive(true);
        NPC1DialogueBox.SetActive(true);

    }
    void OnTriggerExit(Collider other)
    {
        NPC1TalkButton.SetActive(false);
        NPC1DialogueBox.SetActive(false);

    }

}
