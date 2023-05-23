using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappyCollisionManager : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.StopGame();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.AddToScore(1);
    }
}
