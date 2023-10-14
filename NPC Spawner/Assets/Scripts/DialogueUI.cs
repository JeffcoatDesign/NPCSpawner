using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    public static DialogueUI instance;
    public GameObject textBox;
    public Transform dialogueBox;

    private void Awake()
    {
        instance = this;
    }

    public void PrintDialogue (string text)
    {
        TextMeshProUGUI newText = Instantiate(textBox, dialogueBox).GetComponent<TextMeshProUGUI>();
        newText.text = text;
    }
}
