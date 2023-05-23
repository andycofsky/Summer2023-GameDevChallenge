using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ground;
    [SerializeField] GameObject flappyBird;
    [SerializeField] GameObject pipeManager;
    [SerializeField] GameObject UI;

    private int currentScore;
    private int highScore;

    void Start()
    {
        currentScore = 0;
        highScore = 0;
    }

    void Update()
    {
        
    }

    public void StopGame()
    {
        ground.GetComponent<GroundManager>().StopGame();
        flappyBird.GetComponent<FlappyController>().StopGame();
        pipeManager.GetComponent<PipeManager>().StopGame();

        if (currentScore > highScore)
            highScore = currentScore;
    }

    public void StartGame()
    {
        ground.GetComponent<GroundManager>().StartGame();
        flappyBird.GetComponent<FlappyController>().StartGame();
        pipeManager.GetComponent<PipeManager>().StartGame();

        currentScore = 0;
    }


    public void AddToScore(int addition)
    {
        currentScore += addition;
        UI.GetComponent<UserInterface>().UpdateScore(currentScore);
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }
}
