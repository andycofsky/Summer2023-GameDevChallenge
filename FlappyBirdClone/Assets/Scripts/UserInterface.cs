using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UserInterface : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameManager gameManager;

    void Start()
    {
        scoreText.text = "0";
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
