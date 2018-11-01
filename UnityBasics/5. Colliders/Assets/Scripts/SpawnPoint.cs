using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private const float TIME_BETWEEN_SPAWN = 2f;
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
        GameObject arrow = Instantiate(arrowPrefab);
        arrow.transform.position = transform.position;
        arrow.transform.rotation = transform.rotation;
    }

    private void ResetTimer()
    {
        timer = TIME_BETWEEN_SPAWN;
    }
}
