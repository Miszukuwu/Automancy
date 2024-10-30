using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{

    private float timer = 0;
    private GameObject itemGroup;
    private GraveInteraction graveInteractionScript;
    public float timeBetweenItemSpawn = 5;
    [SerializeField] private GameObject item;

    private void Start()
    {
        if (GameObject.Find("Items"))
            itemGroup = GameObject.Find("Items");
        else
            itemGroup = new GameObject();
        graveInteractionScript = gameObject.GetComponent<GraveInteraction>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenItemSpawn && graveInteractionScript.graveLevel != 0) {
            GameObject newItem = Instantiate(item, transform.position - new Vector3(0, 1.2f, 0), transform.rotation, itemGroup.transform);
            timer = 0;
        }
    }
}
