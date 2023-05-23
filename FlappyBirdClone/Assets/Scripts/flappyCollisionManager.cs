using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappyCollisionManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManager>().StopGame();
    }
}
