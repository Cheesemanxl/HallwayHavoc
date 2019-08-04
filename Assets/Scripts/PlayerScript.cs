using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float speed = 1.0f;
    public int hp = 3;
    public int score = 0;
    public Transform weapon;
    public Transform firePoint;

    public int itemNum = 0;
    public GameObject[] items;
    public SpriteRenderer spriteRenderer;
    public Collider2D col;
    public GameObject fireball;
    public Weapon weaponScript;
    public Text scoreText;
    public Canvas deathMenu;

    public bool alive = true;
    public bool hole = false;


    // Start is called before the first frame update
    void Start()
    {
        ChangeItem();
        deathMenu.enabled = false;
    }

    void FixedUpdate()
    {
        if (alive)
        {
            if (!hole)
            {
                Movement();
            }
            else
            {
                items[itemNum].SetActive(false);

                if (transform.position.y > -15.0f) {
                    transform.position = new Vector3(transform.position.x, transform.position.y - (speed * Time.deltaTime), transform.position.z);
                }
                else
                {
                    Death();
                }
            }
        }
    } 

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                weapon.position = new Vector3(transform.position.x + 2.0f, transform.position.y - 0.5f, transform.position.z);

                if (itemNum == 1)
                {
                    Instantiate(fireball, firePoint.position, firePoint.rotation);
                }

                if (itemNum == 2 && !hole)
                {
                    transform.position = new Vector3(transform.position.x, 2.5f, transform.position.z);
                }
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (!hole)
                {
                    weapon.position = new Vector3(transform.position.x + 2.0f, transform.position.y + 2.0f, transform.position.z);
                    transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
                }

            }

            if (Input.mouseScrollDelta.y > 0.0f)
            {
                if (itemNum < items.Length - 1)
                {
                    itemNum++;
                    ChangeItem();
                }
                else
                {
                    itemNum = 0;
                    ChangeItem();
                }
            }
            else if (Input.mouseScrollDelta.y < 0.0f)
            {
                if (itemNum > 0)
                {
                    itemNum--;
                    ChangeItem();
                }
                else
                {
                    itemNum = items.Length - 1;
                    ChangeItem();

                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            {
                itemNum = 0;
                ChangeItem();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            {
                itemNum = 1;
                ChangeItem();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            {
                itemNum = 2;
                ChangeItem();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
            {
                itemNum = 3;
                ChangeItem();
            }
        }
    }

    void Movement()
    {

        transform.position = new Vector3 (transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);

    }

    void UseWeapon()
    {

        weapon.position = Vector3.right;

    }

    public void TakeDmg()
    {
        hp--;
        if (hp <= 0)
        {
            Death();
        }

    }

    public void ScoreUp(int amount)
    {
        if (alive)
        {
            score += amount;
            scoreText.text = "Score: " + score;
        }
    }

    public void Death()
    {
        alive = false;
        deathMenu.enabled = true;
        Destroy(gameObject);
    }

    void ChangeItem()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (itemNum == i)
            {
                items[i].SetActive(true);
            }
            else
            {
                items[i].SetActive(false);
            }
        }
    }

}
