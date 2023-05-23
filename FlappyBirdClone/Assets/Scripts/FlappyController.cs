using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float upMultiplier;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
            rb.velocity = new Vector2(0, upMultiplier);
    }
}
