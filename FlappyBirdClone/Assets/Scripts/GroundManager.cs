using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    Transform transform;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0));
        if (transform.position.x <= -4.7f)
            transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
    }
}
