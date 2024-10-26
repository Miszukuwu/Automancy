using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class MoveItem : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<NavMeshAgent>().destination = GameObject.FindGameObjectWithTag("Stash").transform.position;
    }
    void Update()
    {
        transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
    }
}
