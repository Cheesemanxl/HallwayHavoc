using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private int count = 0;

    void FixedUpdate()
    {
        transform.position += Vector3.right * 20.0f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        DestroyAfterDelay();
    }

    void DestroyAfterDelay()
    {
        if (count < 720)
        {
            count++;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
