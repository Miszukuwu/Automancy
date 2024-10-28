using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{

    private float timer = 0;
    private GameObject itemGroup;
    [SerializeField] private float timeBetweenItemSpawn = 5;
    [SerializeField] private GameObject item;

    private void Start()
    {
        if (GameObject.Find("Items"))
            itemGroup = GameObject.Find("Items");
        else
            itemGroup = new GameObject();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenItemSpawn) {
            GameObject newItem = Instantiate(item, transform.position, transform.rotation, itemGroup.transform);
            timer = 0;
        }
    }
}
