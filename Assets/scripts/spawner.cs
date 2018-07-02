using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    // Use this for initialization
    public Transform[] spawnPoints;
    public GameObject pumpkin;
	void Start () {
        StartCoroutine(StartSpawning());
    }
	
IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(.2f, 1.0f));
        Instantiate(pumpkin,spawnPoints[Random.Range(0,spawnPoints.Length)].position,Quaternion.identity);
        StartCoroutine(StartSpawning());
    }
}
