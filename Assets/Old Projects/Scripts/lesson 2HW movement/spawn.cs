using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] GameObject spawnObj;
    [SerializeField] Transform spawnPoint;
    private float nextSpavnTime;
    void Update()
    {
        if (Time.time > nextSpavnTime)
        {
            Instantiate(spawnObj, spawnPoint);
            nextSpavnTime = Time.time + 2;
        }
    }
}