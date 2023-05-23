using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ground;
    [SerializeField] GameObject flappyBird;
    [SerializeField] GameObject pipeManager;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StopGame()
    {
        ground.GetComponent<GroundManager>().StopGame();
        flappyBird.GetComponent<FlappyController>().StopGame();
        pipeManager.GetComponent<PipeManager>().StopGame();
    }

    public void StartGame()
    {
        ground.GetComponent<GroundManager>().StartGame();
        flappyBird.transform.position = Vector3.zero;
    }
}
