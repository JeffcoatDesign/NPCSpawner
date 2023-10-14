using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : INPC
{
    public void Speak()
    {
        DialogueUI.instance.PrintDialogue("Farmer: You reap what you sow!");
        Debug.Log("You reap what you sow!");
    }
}
