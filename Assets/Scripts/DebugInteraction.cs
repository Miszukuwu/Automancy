using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class DebugInteraction : MonoBehaviour, Interactable
{
    public void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
    }
}
