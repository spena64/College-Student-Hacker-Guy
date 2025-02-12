﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rb; 

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.magnitude > 1000.0f) 
        {
            Destroy(gameObject); 
        }
    }

    public void Launch (Vector2 direction, float force)
    {
        rb.AddForce(direction * force); 
        Debug.Log("projectile launched"); 
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        other.GetComponent<BugMovement>().GetPunched();

        Destroy(gameObject); 
    }
}
