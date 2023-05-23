using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] float speed;
    Transform groundTransform;
    
    private bool gameStopped;

    // Start is called before the first frame update
    void Start()
    {
        groundTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStopped)
        {
            groundTransform.Translate(new Vector3(-speed * Time.deltaTime, 0));
            if (transform.position.x <= -4.7f)
                transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        }
    }

    public void StopGame()
    {
        gameStopped = true;
    }

    public void StartGame()
    {
        gameStopped = false;
    }
}
