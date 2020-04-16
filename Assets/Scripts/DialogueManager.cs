﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    
    public Text nameText;
    public Text dialogueText;


    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
        
    }




    public void StartDialogue (Dialogue dialogue)
    {
        //Debug.Log("Starting conversation with " + dialogue.name);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
    
        }
        DisplayNextSentence();
    
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        //Debug.Log(sentence);
    
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
            yield return null;

        }


    }


    void EndDialogue()
    {
        Debug.Log("End of conversation.");
        
    }

    /*
    void OnBecameVisible()
    {
        enabled = true;
        
    }
    void OnBecameInvisible()
    {
        enabled = false;

    }
    */
}
