using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text highScoreText;
    [SerializeField] Button restartButton;
    [SerializeField] GameManager gameManager;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        restartButton.enabled = false;
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void StopGame()
    {
        restartButton.enabled = true;
        highScoreText.text = gameManager.GetHighScore().ToString();
        animator.Play("Base Layer.UI Stopping", -1, 0.0f);
    }

    public void StartGame()
    {
        restartButton.enabled = false;
        animator.Play("Base Layer.Playing", -1, 0.0f);
    }
}
