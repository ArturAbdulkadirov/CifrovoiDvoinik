using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class DummySpawner : MonoBehaviour
{
    public GameObject dummy;

    private float maxX, maxZ, minX, minZ;

    private void Start()
    {
        maxX = transform.position.x + transform.localScale.x / 2;
        minX = transform.position.x - transform.localScale.x / 2;
        
        maxZ = transform.position.z + transform.localScale.z / 2;
        minZ = transform.position.z - transform.localScale.z / 2;
    }

    public void SpawnDummy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), transform.position.y, Random.Range(minZ,maxZ));
        Instantiate(dummy, spawnPos, Random.rotation);
    }

#if UNITY_ANDROID
    private void Update()
    {
        maxX = transform.position.x + transform.localScale.x / 2;
        minX = transform.position.x - transform.localScale.x / 2;
        
        maxZ = transform.position.z + transform.localScale.z / 2;
        minZ = transform.position.z - transform.localScale.z / 2;
    }
#endif
}
