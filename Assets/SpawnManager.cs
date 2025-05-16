using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spamRangeX=5;
    private float spamPosZ=1;
    private float startDelay=2;
    private float spamInterval=1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay, spamInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spamPos = new Vector3(Random.Range(-spamRangeX,spamRangeX),0 ,spamPosZ);
        Instantiate(animalPrefabs[animalIndex],spamPos, animalPrefabs[animalIndex].transform.rotation);
    }
}