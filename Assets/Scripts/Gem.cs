using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyAfterDelay();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerScript player = col.GetComponent<PlayerScript>();
        Sword sword = col.GetComponent<Sword>();
        Fireball fireball = col.GetComponent<Fireball>();

        if (player != null)
        {
            Destroy(gameObject);
            player.ScoreUp(1);
        }

        if (sword != null)
        {
            Destroy(gameObject);
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
