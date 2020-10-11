using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AimingBullet : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject player;
    private GameObject enemy;
    public float defaultSpeed = 5.0f;

    void Start()
    {
        Debug.Log("Hi");
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        this.Shoot(player.transform.position, enemy.transform.position, defaultSpeed);
    }

    public void Shoot(
       Vector3 pPos, // player's location
       Vector3 ePos,  // enemy's location
       float speed     // bullet's speed
   )
    {
        Vector2 direction = new Vector2(pPos.x - ePos.x, pPos.y - ePos.y);
        direction.Normalize();
        rb.velocity = direction * speed;
    }
}
