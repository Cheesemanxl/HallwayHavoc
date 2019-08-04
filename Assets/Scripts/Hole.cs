using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private int count;
    private bool teardropTattoo = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!teardropTattoo)
        {
            DestroyAfterDelay();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerScript player = col.GetComponent<PlayerScript>();

        if (player != null)
        {
            player.hole = true;
            teardropTattoo = true;
        }
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
