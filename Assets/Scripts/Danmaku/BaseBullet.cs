using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBullet : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected Vector2 direction;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public virtual void LoadFire() { }

    public virtual void Fire(float speed)
    {
        direction.Normalize();
        rb.velocity = direction * speed;
    }

    public override string ToString()
    {
        return "BaseBullet";
    }
}
