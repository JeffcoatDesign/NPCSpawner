using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    [SerializeField] private NPCFactory _factory;

    private INPC _farmer;
    private INPC _beggar;
    private INPC _shopkeep;

    public void SpawnVillagers()
    {
        _beggar = _factory.GetNPC(NPCType.Beggar);
        _shopkeep = _factory.GetNPC(NPCType.Shopowner);
        _farmer = _factory.GetNPC(NPCType.Farmer);

        _beggar.Speak();
        _farmer.Speak();
        _shopkeep.Speak();
    }
}
