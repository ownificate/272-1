using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRocket : MonoBehaviour
{
    public GameObject shipFiring;
    public GameObject missile;
    public KeyCode fire;
    float x,y;
    float speed = 0.8f;

    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(fire))
        {
            GameObject tmpMissile;
            tmpMissile = Instantiate(missile,new Vector3(shipFiring.transform.position.x - 1.0f, shipFiring.transform.position.y,0),
                Quaternion.Euler(0,0,180)) as GameObject;

            tmpMissile.transform.position = new Vector3(x,y,0);
        }
    }
}
