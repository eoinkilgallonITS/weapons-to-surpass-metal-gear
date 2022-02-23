using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //Data
    public int ammo;
    public bool isAutomatic;
    public GameObject BulletPrefab;

    //Actions
    public virtual void Fire(Vector3 firirgPosition) 
    {
        ammo--;
    }
}

