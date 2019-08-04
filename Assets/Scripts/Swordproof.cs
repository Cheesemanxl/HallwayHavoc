using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordproof : MonoBehaviour
{
    private int count;
    private bool teardropTattoo;

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
        Fireball fireball = col.GetComponent<Fireball>();

        if (player != null)
        {
            player.TakeDmg();
            teardropTattoo = true;
        }

        if (fireball != null)
        {
            Destroy(gameObject);
            Destroy(fireball.gameObject);
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
