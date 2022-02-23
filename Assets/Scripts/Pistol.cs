using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    public override void Fire()
    {
        Bullet newBullet = Instantiate(BulletPrefab, firingPoint.position, Quaternion.identity);

        newBullet.SetDirection(Owner.transform.up);

        base.Fire();
    }
}
