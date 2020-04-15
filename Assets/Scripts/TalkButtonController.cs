using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkButtonController : MonoBehaviour
{
    public GameObject NPC1TalkButton;
    public GameObject NPC1DialogueBox;

    public Button yourButton;


    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //NPC1TalkButton.SetActive(false);
        NPC1DialogueBox.SetActive(true);
    }

}
