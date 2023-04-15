using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class RandomPointOnNavMesh : MonoBehaviour
{
    public GameObject collectable;
    public static bool ObjectDestroyed = false;

    private void Start()
    {
        SpawnCollectable();
    }

    void Update()
    {
        if (ObjectDestroyed == true)
        { ObjectDestroyed = false; SpawnCollectable(); }
    }

    public void SpawnCollectable()
    {
        Vector3 randomOffset = 11f * Random.insideUnitSphere;
        Vector3 randomPosition = transform.position + randomOffset;

        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPosition, out hit, 11.0f, NavMesh.AllAreas))
        {
            randomPosition = hit.position;
        }
        randomPosition.y = 1.5f;

        Quaternion rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(collectable, randomPosition, rotation);
    }
}
