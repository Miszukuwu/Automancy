using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{

    private float timer = 0;
    [SerializeField] private float timeBetweenItemSpawn = 5;
    [SerializeField] private GameObject item;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenItemSpawn) {
            GameObject newItem = Instantiate(item, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
