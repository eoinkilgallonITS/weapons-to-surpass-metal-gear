using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Gun activeGun;
    public Gun activeGunTwo;
    void Start()
    {
        activeGun.Owner = gameObject;
    }

    void Update()
    {
        
        if (activeGun.isAutomatic && activeGunTwo.isAutomatic)
        {
            if (Input.GetButton("Fire1"))
            {
                activeGun.Fire();
                activeGunTwo.Fire();
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire1"))
            {
                activeGun.Fire();
                activeGunTwo.Fire();
            }
        }
    }
}
