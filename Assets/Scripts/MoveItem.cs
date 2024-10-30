using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class MoveItem : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject targetObject;
    private MarketStall marketStallScript;
    [SerializeField] private int itemPrice = 5;
    private Sprite[] itemSprites;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetObject = GameObject.FindGameObjectWithTag("Stash");
        agent.destination = targetObject.transform.position;
        marketStallScript = targetObject.GetComponent<MarketStall>();
        
        itemSprites = Resources.LoadAll<Sprite>("Items");
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = itemSprites[UnityEngine.Random.Range(0, itemSprites.Length)];
    }
    void Update()
    {
        transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        if (agent.remainingDistance <= 0.1)
        {
            marketStallScript.addStashedItem();
            Destroy(gameObject);
        }
    }
}
