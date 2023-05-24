using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UserInterface : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameManager gameManager;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        scoreText.text = "0";
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void StopGame()
    {
        animator.Play("Base Layer.UI Stopping", -1, 0.0f);
    }

    public void StartGame()
    {
        animator.Play("Base Layer.Playing", -1, 0.0f);
    }
}
