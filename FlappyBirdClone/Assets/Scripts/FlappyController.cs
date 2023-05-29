using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyController : MonoBehaviour
{
    [SerializeField] float upMultiplier;
    [SerializeField] GameObject flappySprite;
    [SerializeField] GameManager gameManager;

    public bool gameStopped;
    public bool waitingForInput;

    private Transform flappyTransform;
    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        gameStopped = false;
        waitingForInput = true;
        flappyTransform = transform;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();

        rb.simulated = false;
    }

    void Update()
    {
        if (waitingForInput)
        {
            if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
            {
                rb.simulated = true;
                waitingForInput = false;
                animator.Play("Base Layer.flappybird", -1, 0.0f);
                animator.Play("Dive Layer.Dive", -1, 0.0f);

                gameManager.StartPipes();
            }
        }

        if (!gameStopped && !waitingForInput)
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
        rb.simulated = false;
        animator.enabled = false;
    }

    public void StartGame()
    {
        gameStopped = false;
        waitingForInput = true;

        animator.enabled = true;

        flappyTransform.position = Vector3.zero;
        flappySprite.transform.rotation = Quaternion.Euler(Vector3.zero);

        animator.Play("Base Layer.Idle", -1, 0.0f);
        animator.Play("Dive Layer.Idle", -1, 0.0f);
    }
}
