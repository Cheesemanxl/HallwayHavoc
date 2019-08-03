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
    private int count;
    private bool spawned;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DelaySpawn();
    }

    void ChooseSpawn()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            rand = Random.value;

            if (rand < 0.5f && spawned == false) {
                Instantiate(prefabs[i], transform.position, transform.rotation);
                spawned = true;
            }
        }

        spawned = false;
    }

    void DelaySpawn()
    {
        if (count < 432)
        {
            count++;
        }
        else
        {
            ChooseSpawn();
            count = 0;
        }
    }
}
