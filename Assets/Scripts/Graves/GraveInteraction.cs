using System;
using Script;
using UnityEngine;

public class GraveInteraction : MonoBehaviour, Interactable
{
    private int graveLevel = 0;

    private void upgradeGrave()
    {
        graveLevel++;
        if (graveLevel < GameManager.graveSprites.Length)
        {
            gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = GameManager.graveSprites[graveLevel];
        }
    }
    public void Interact()
    {
        upgradeGrave();
    }
}
