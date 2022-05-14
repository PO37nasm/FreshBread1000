using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform duckParent;
    [SerializeField]
    private GameObject duck;
    [SerializeField]
    private int duckTotal;
    [SerializeField]
    private Terrain terrain;

    private void Start()
    {
        int i = 0;
        while (i <= duckTotal)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(terrain.terrainData.bounds.min.x, terrain.terrainData.bounds.max.x) - terrain.terrainData.bounds.extents.x, 2, Random.Range(terrain.terrainData.bounds.min.z, terrain.terrainData.bounds.max.z) - terrain.terrainData.bounds.extents.z);

            if (terrain.SampleHeight(spawnPoint) < 55)
            {
                //Debug.Log("Checking height at" + spawnPoint + ":" + terrain.SampleHeight(spawnPoint));
                Instantiate<GameObject>(duck, spawnPoint, Quaternion.identity, duckParent);
                i++;
            }
            else
            {
                i++;
            }
            
        }
        
    }
}
