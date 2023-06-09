using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] float timeBetweenPipes;

    IEnumerator SpawnPipe()
    {
        yield return new WaitForSeconds(6.0f);
        GameObject child;
        while (true)
        {
            child = Instantiate(pipePrefab, new Vector3(3.7f, Random.Range(-0.5f, 2.2f), 0), Quaternion.identity);
            child.transform.parent = transform;
            yield return new WaitForSeconds(timeBetweenPipes);
        }
    }

    public void StopGame()
    {
        StopAllCoroutines();
        foreach (Transform child in transform)
        {
            child.GetComponent<Pipes>().gameStopped = true;
        }
    }

    public void StartGame()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void SpawnPipes()
    {
        StartCoroutine(SpawnPipe());
    }    
}
