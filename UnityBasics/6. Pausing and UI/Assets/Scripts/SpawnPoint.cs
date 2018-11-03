using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private const float TIME_BETWEEN_SPAWN = 2f;

    public bool randomiseSpawnPoint;
    public float minSpawnPoint;
    public float maxSpawnPoint;

    private GameObject arrowPrefab;
    private float timer;

    void Start () 
    {
        arrowPrefab = Resources.Load<GameObject>("Arrow");  
    }
    
    void Update () 
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            SpawnArrow();
            ResetTimer();
        }
    }

    private void SpawnArrow()
    {
        Vector2 currentPosition = transform.position;

        if (randomiseSpawnPoint)
        {
            float randomPos = UnityEngine.Random.Range(minSpawnPoint, maxSpawnPoint);
            transform.position += transform.up * randomPos;
        }

        GameObject arrow = Instantiate(arrowPrefab);
        arrow.transform.position = transform.position;
        arrow.transform.rotation = transform.rotation;

        transform.position = currentPosition;
    }

    private void ResetTimer()
    {
        timer = TIME_BETWEEN_SPAWN;
    }
}
