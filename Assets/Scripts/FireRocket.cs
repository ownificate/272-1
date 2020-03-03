using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRocket : MonoBehaviour
{
    [SerializeField] private Transform fireLocation;
    [SerializeField] private KeyCode fire;
    public GameObject missile;
    float x,y;
    float speed = 0.8f;

    Rigidbody2D rb2d;
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(fire))
        {
            GameObject tmpMissile;
            tmpMissile = Instantiate(missile, fireLocation.position, Quaternion.Euler(0,0,180)) as GameObject;

            tmpMissile.transform.position = new Vector3(x,y,0);

            Destroy(tmpMissile, 10.0f);
        }
    }
}
