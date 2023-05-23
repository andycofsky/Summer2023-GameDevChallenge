using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public void OnButtonPress()
    {
        gameManager.StartGame();
    }
}
