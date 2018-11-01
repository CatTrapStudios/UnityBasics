using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour 
{
    private const float SPEED = 10f;

	void Update () 
    {
        transform.position += -transform.right * SPEED * Time.deltaTime; 

        if (ShouldBeDestroyed())
        {
            Destroy(gameObject);
        }
	}

    private bool ShouldBeDestroyed()
    {
        return Vector2.Distance(Vector2.zero, transform.position) > 30;
    }
}
