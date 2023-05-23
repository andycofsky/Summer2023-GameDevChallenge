using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] float pipeSpeed;
    public bool gameStopped;

    void Start()
    {
        gameStopped = false;
    }

    void Update()
    {
        if (!gameStopped)
        {
            transform.Translate(new Vector3(-pipeSpeed * Time.deltaTime, 0));
            if (transform.position.x <= -4.0f)
                Destroy(gameObject);
        }
    }
}
