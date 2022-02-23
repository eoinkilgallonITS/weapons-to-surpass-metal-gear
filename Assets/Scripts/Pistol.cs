using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    public override void Fire(Vector3 firirgPosition)
    {
        Instantiate(BulletPrefab, firirgPosition, Quaternion.identity);
        base.Fire(firirgPosition);
    }
}
