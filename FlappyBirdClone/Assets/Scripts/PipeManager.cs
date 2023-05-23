using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;

    void Start()
    {
        Instantiate(pipePrefab, new Vector3(3.7f, 0.54f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
