using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRocket : MonoBehaviour
{
    [SerializeField] private Transform fireLocation;
    [SerializeField] private KeyCode fire;
    public GameObject missile;
    void Update()
    {
        if(Input.GetKeyDown(fire))
        {
            GameObject tmpMissile;
            tmpMissile = Instantiate(missile, fireLocation.position, Quaternion.Euler(0,0,180)) as GameObject;
            Destroy(tmpMissile, 10.0f);
        }
    }
}
