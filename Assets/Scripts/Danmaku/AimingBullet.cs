using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AimingBullet : BaseBullet
{
    protected GameObject player;
    protected GameObject spawn;

    protected override void Awake()
    {
        base.Awake();
        player = GameObject.FindGameObjectWithTag("Player");
        spawn = GameObject.FindGameObjectWithTag("Spawn");
    }

    public override void LoadFire()
    {
        Vector3 pPos = this.player.transform.position;
        Vector3 ePos = this.spawn.transform.position;
        direction = new Vector2(pPos.x - ePos.x, pPos.y - ePos.y);
    }

    public override string ToString()
    {
        return "AimingBullet";
    }
}
