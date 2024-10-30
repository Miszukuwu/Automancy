using Script;
using UnityEngine;

public class MarketStall : MonoBehaviour, Interactable
{
    public void Interact() 
    {
        Debug.Log("Interacted with Market Stall");
    }
    private int amountOfStashedItems = 0;
    public void addStashedItem() 
    {
        amountOfStashedItems++;
    }
    
}
