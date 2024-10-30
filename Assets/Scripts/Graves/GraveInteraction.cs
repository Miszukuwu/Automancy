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
        
        switch (graveLevel+1)
        {
            case 1:
                if (GameManager.playerMoney - 75 < 0)
                {
                    return;
                }
                GameManager.playerMoney -= 75; break;
            case 2:
                if (GameManager.playerMoney - 200 < 0)
                {
                    return;
                }
                GameManager.playerMoney -= 200; break;
            case 3:
                if (GameManager.playerMoney - 500 < 0)
                {
                    return;
                }
                GameManager.playerMoney -= 500; break;
        }
        
        graveLevel++;
        if (graveLevel <= maxGraveLevel)
        {
            gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = GameManager.graveSprites[graveLevel];
        }

        if (graveLevel != 1 && graveLevel <= maxGraveLevel)
        {
            spawnItemsScript.timeBetweenItemSpawn -= 2;
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
