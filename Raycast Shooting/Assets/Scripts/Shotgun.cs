using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : RayCastWeapon
{
    public Vector3 Spread = new Vector3(0.1f, 0, 0);
    public override void Fire(Vector3 fireFromPosition)
    {
        base.Fire(fireFromPosition);
    }

    private void ShootRay(Vector3 position, Vector3 direction)
    {

    }

}
