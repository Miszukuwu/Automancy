using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItem : MonoBehaviour
{
    private GameObject nearestTarget;
    private GameObject[] possibleTargets;
    [SerializeField] private float movingSpeed = 100;

    /// <summary>
    /// Finds nearest game object from array to the game object
    /// </summary>
    /// <param name="possibleTargets">Array of GameObjects that may be targets</param>
    /// <param name="gameObject">Game object that we check from</param>
    /// <returns>Nearest game object</returns>
    private GameObject FindTheNearestGameObject(GameObject[] possibleTargets, GameObject gameObject) {
        GameObject nearestTarget;
        nearestTarget = possibleTargets[0];

        for(int i = 1; i < possibleTargets.Length; i++) {
            if(Vector2.Distance(transform.position, possibleTargets[i].transform.position) < Vector2.Distance(transform.position, nearestTarget.transform.position)) {
                nearestTarget = possibleTargets[i];
            }
        }

        return nearestTarget;
    }
    void Start()
    {
        possibleTargets = GameObject.FindGameObjectsWithTag("ItemTargetDestination");
        nearestTarget = FindTheNearestGameObject(possibleTargets, gameObject);
    }
    void Update()
    {
        //Moves item to the nearest target according to speed
        transform.position += movingSpeed * Time.deltaTime * (nearestTarget.transform.position - transform.position).normalized;
    }
}
