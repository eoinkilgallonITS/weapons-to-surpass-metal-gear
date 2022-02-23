using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public float speed;
 
    public void SetDirection(Vector3 direction)
    { 
       Rigidbody2D body = GetComponent<Rigidbody2D>();
        body.velocity = direction * speed;
    }
 
}
