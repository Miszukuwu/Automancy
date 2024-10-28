using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class MoveItem : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject targetObject;
    private ZombieAssembler zombieAssemblerScript;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetObject = GameObject.FindGameObjectWithTag("Stash");
        agent.destination = targetObject.transform.position;
        zombieAssemblerScript = targetObject.GetComponent<ZombieAssembler>();
    }
    void Update()
    {
        transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        if (agent.remainingDistance <= 0.1 && zombieAssemblerScript.amountOfItems < 5)
        {
            zombieAssemblerScript.amountOfItems++;
            Destroy(gameObject);
        }
    }
}
