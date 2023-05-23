using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyController : MonoBehaviour
{
    [SerializeField] float upMultiplier;
    public bool gameStopped;

    private Transform flappyTransform;
    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        gameStopped = false;
        flappyTransform = transform;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (!gameStopped)
        {
            if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
            {
                animator.Play("Dive Layer.Dive", -1, 0.0f);
                rb.velocity = new Vector2(0, upMultiplier);
            }
        }
    }

    public void StopGame()
    {
        gameStopped = true;
        GetComponent<Rigidbody2D>().simulated = false;
        animator.enabled = false;
    }

    public void StartGame()
    {
        gameStopped = false;
        GetComponent<Rigidbody2D>().simulated = true;
        animator.enabled = true;

        flappyTransform.position = Vector3.zero;
        animator.Play("Dive Layer.Dive", -1, 0.0f);
    }
}
