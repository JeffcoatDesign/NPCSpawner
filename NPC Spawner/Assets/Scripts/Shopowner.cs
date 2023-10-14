using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopowner : INPC
{
    public void Speak()
    {
        DialogueUI.instance.PrintDialogue("Shopowner: Do you wish to purchase something?");
        Debug.Log("Do you wish to purchase something?");
    }
}
