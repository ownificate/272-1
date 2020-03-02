using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public GameObject shipFiring;
    public GameObject missile;
    public KeyCode fire;
    float x,y;
    float speed = 0.04f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(fire))
        {
            GameObject tmpMissile;
            tmpMissile = Instantiate(missile,new Vector3(shipFiring.transform.position.x - 1,shipFiring.transform.position.y - 1,0),Quaternion.Euler(0,0,180)) as GameObject;
            x -= speed;
            y = transform.position.y;

            transform.position = new Vector3(x,y,0);
            Destroy(tmpMissile, 5.0f);
        }
    }
}
