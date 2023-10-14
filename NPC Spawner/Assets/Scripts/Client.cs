using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner spawner;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            spawner.SpawnVillagers();
    }
}
