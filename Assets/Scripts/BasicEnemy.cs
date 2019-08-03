using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerScript player = col.GetComponent<PlayerScript>();
        Weapon weapon = col.GetComponent<Weapon>();

        if (player != null)
        {
            player.TakeDmg();
            DeathCount();
        }

        if (weapon != null)
        {
            Destroy(gameObject);
        }

    }

    void DeathCount()
    {

        if (count < 144)
        {
            count++;
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
