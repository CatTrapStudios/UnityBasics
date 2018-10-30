using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private const float SPEED = 2.5f;

    void Update()
    {
        Vector3 position = transform.position;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= SPEED * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            position.x += SPEED * Time.deltaTime;
        }

        transform.position = position;
    }
}