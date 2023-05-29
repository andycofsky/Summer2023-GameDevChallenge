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
        if (currentScore > highScore)
            highScore = currentScore;

        ground.GetComponent<GroundManager>().StopGame();
        flappyBird.GetComponent<FlappyController>().StopGame();
        pipeManager.GetComponent<PipeManager>().StopGame();
        UI.GetComponent<UserInterface>().StopGame();
    }

    public void StartGame()
    {
        ground.GetComponent<GroundManager>().StartGame();
        flappyBird.GetComponent<FlappyController>().StartGame();
        pipeManager.GetComponent<PipeManager>().StartGame();
        UI.GetComponent<UserInterface>().StartGame();

        currentScore = 0;
        UI.GetComponent<UserInterface>().UpdateScore(currentScore);
    }

    public void StartPipes()
    {
        pipeManager.GetComponent<PipeManager>().SpawnPipes();
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

    public int GetHighScore()
    {
        return highScore;
    }
}
