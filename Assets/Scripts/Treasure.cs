using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    private int count = 0;
    private bool activated = false;
    public PlayerScript player;
    public SpriteRenderer spriteRender;
    public Sprite opened;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
        DestroyAfterDelay();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerScript player = col.GetComponent<PlayerScript>();
        Sword sword = col.GetComponent<Sword>();
        Fireball fireball = col.GetComponent<Fireball>();
        KeyScript key = col.GetComponent<KeyScript>();

        if (key != null)
        {
            activated = true;
            spriteRender.sprite = opened;
        }

        if (player != null)
        {
            if (activated)
            {
                player.ScoreUp(10);
                Destroy(gameObject);
            }
            
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