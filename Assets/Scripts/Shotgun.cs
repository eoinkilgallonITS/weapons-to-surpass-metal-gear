using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Gun
{
    public override void Fire()
    {
        CreatePellet(firingPoint.position);
        CreatePellet(firingPoint.position + new Vector3(1, 0));
        CreatePellet(firingPoint.position - new Vector3(1, 0));
        CreatePellet(firingPoint.position + new Vector3(2, 0));
        CreatePellet(firingPoint.position - new Vector3(2, 0));
        base.Fire();
    }

    void CreatePellet(Vector2 startposition)
    {
        Bullet newBullet = Instantiate(BulletPrefab,
            startposition,
            Quaternion.identity);

        newBullet.SetDirection(Owner.transform.up);
    }
}
