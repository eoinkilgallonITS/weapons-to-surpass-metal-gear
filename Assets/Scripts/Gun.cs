using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //Data
    public int ammo;
    public bool isAutomatic;
    public Bullet BulletPrefab;
    public Transform firingPoint;

    public GameObject Owner;

    //Actions
    public virtual void Fire() 
    {
        ammo--;
    }
}