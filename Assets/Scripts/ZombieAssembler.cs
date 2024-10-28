using UnityEngine;

public class ZombieAssembler : MonoBehaviour
{
    [HideInInspector] public int amountOfItems = 0;
    [SerializeField] private float assemblyTime = 5f;
    [SerializeField] private GameObject zombiePrefab;

    private void InstantiateZombie()
    {
        Instantiate(zombiePrefab, transform.position + new Vector3(1f, 0, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        if (amountOfItems >= 5)
        {
            Invoke("InstantiateZombie", assemblyTime);
            amountOfItems = 0;
        }
    }
}
