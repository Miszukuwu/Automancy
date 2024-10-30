using System;
using Script;
using UnityEngine;

public class GraveInteraction : MonoBehaviour, Interactable
{
    private SpawnItems spawnItemsScript;
    private int maxGraveLevel;
    [SerializeField] public int graveLevel = 0;

    private void upgradeGrave()
    {
        maxGraveLevel = GameManager.graveSprites.Length - 1;
        
        graveLevel++;
        if (graveLevel <= maxGraveLevel)
        {
            gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = GameManager.graveSprites[graveLevel];
        }

        if (graveLevel != 1 && graveLevel <= maxGraveLevel)
        {
            spawnItemsScript.timeBetweenItemSpawn -= 2;
        }

        switch (graveLevel)
        {
            case 1: GameManager.playerMoney -= 75; break;
            case 2: GameManager.playerMoney -= 200; break;
            case 3: GameManager.playerMoney -= 500; break;
        }

        Debug.Log(GameManager.playerMoney);
    }
    public void Interact()
    {
        upgradeGrave();
    }

    private void Start()
    {
        spawnItemsScript = GetComponent<SpawnItems>();
    }
}
