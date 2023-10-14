using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beggar : INPC
{
    public void Speak()
    {
        DialogueUI.instance.PrintDialogue("Beggar: Do you have some change to spare?");
        Debug.Log("Do you have some change to spare?");
    }
}
