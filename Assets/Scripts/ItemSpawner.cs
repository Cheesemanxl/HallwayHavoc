using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public Transform player;
    public GameObject[] prefabs;
    private Vector3 lastDrop;
    private Vector3 pos;
    private float rand = 0.0f;
    private int count = 0;
    private bool spawned;
    private int choice = 0;
    private int chances = 4;

    // Update is called once per frame
    void Update()
    {
        DelaySpawn();
    }

    void SpawnObj()
    {
        for (int i = 0; i < chances; i++)
        {
            ChooseSpawn();

            rand = Random.value;

            if (rand < 0.5f && spawned == false) {

                if (player != null) {
                    Instantiate(prefabs[choice], transform.position, transform.rotation);
                }
                spawned = true;
            }
        }

        spawned = false;
    }

    void DelaySpawn()
    {
        if (count < 360)
        {
            count++;
        }
        else
        {
            SpawnObj();
            count = 0;
        }
    }

    void ChooseSpawn()
    {
        rand = Random.value;

        if (rand <= 0.16)
        {
            choice = 0;
        }
        else if (rand > 0.16f && rand <= 0.32f)
        {
            choice = 1;
        }
        else if (rand > 0.32f && rand <= 0.48f)
        {
            choice = 2;
        }
        else if (rand > 0.48f && rand <= 0.64f)
        {
            choice = 3;
        }
        else if (rand > 0.64f && rand <= 0.8f)
        {
            choice = 4;
        }
        else if (rand > 0.8f && rand <= 1.0f)
        {
            choice = 5;
        }
        else
        {
            choice = 0;
        }
    }
}
