using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform tm1;
    public Transform tm2;
    public Transform tm3;
    public Transform player;

    private Vector3 pLoc;
    private Vector3 t1Loc;
    private Vector3 t2Loc;
    private Vector3 t3Loc;

    private int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        pLoc = player.position;
        t1Loc = tm1.position;
        t2Loc = tm2.position;
        t3Loc = tm3.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null)
        {
            if (player.position.x > pLoc.x + 18)
            {
                pLoc = player.position;

                if (count == 0)
                {
                    tm1.position = new Vector3(t3Loc.x + 18.0f, t1Loc.y, t1Loc.z);
                    t1Loc = tm1.position;
                    count++;
                }
                else if (count == 1)
                {
                    tm2.position = new Vector3(t1Loc.x + 18.0f, t2Loc.y, t2Loc.z);
                    t2Loc = tm2.position;
                    count++;
                }
                else if (count == 2)
                {
                    tm3.position = new Vector3(t2Loc.x + 18.0f, t3Loc.y, t3Loc.z);
                    t3Loc = tm3.position;
                    count = 0;
                }
            }
        }
    }

}
