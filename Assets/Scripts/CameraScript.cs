using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    private float offset = 7.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null) {
            transform.position = new Vector3(player.position.x + offset, transform.position.y, transform.position.z);
        }
    }
}
