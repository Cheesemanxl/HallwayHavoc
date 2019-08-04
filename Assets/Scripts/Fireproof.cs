using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireproof : MonoBehaviour
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
        Sword sword = col.GetComponent<Sword>();
        Fireball fireball = col.GetComponent<Fireball>();

        if (player != null)
        {
            player.TakeDmg();
            teardropTattoo = true;
        }

        if (sword != null)
        {
            Destroy(gameObject);
        }

        if (fireball != null)
        {
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
