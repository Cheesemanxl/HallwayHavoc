using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 1.0f;

    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        pos += Vector3.right;
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
        pos = transform.position;
    }
}
