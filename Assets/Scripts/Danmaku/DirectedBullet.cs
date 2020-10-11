using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class DirectedBullet : BaseBullet
{
    public override void LoadFire()
    {
        direction = new Vector2(0f, -1.0f);
    }

    public override string ToString()
    {
        return "DirectedBullet";
    }
}
