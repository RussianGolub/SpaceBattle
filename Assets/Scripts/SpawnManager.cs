using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnPointsList;
    [SerializeField] private Transform objectTemplate;

    [SerializeField] private float nextSpanwTimer;
    private float spanwTimer;

    private void Awake() {
        spanwTimer=nextSpanwTimer;
    }

    private void Update() {
        spanwTimer-= Time.deltaTime;
        if(spanwTimer<=0)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(objectTemplate,spawnPointsList[UnityEngine.Random.Range(0,spawnPointsList.Count)]);
        spanwTimer = nextSpanwTimer;
    }
}
