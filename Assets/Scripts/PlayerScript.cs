using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 1.0f;
    public int hp = 100;
    public int score = 0;
    public Transform weapon;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            weapon.position = new Vector3(transform.position.x + 2.0f, transform.position.y - 0.5f, transform.position.z);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            weapon.position = new Vector3(transform.position.x + 2.0f, transform.position.y + 2.0f, transform.position.z);
        }
    }

    void Movement()
    {

        transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.right, Time.deltaTime * speed);

    }

    void UseWeapon()
    {

        weapon.position = Vector3.right;

    }

    public void TakeDmg()
    {
        hp--;
        Debug.Log(hp);
    }

    public void Death()
    {
        Destroy(gameObject);
    }

}
