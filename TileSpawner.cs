using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTrans;
    private float spawnz = -50.0f;
    private float tileLength = 100.0f;
    private int SafeArea = 4;
    private float SafeTime = 120.0f;
    private int lastPref = 0;

    private List<GameObject> activiteTiles;

    void Start()
    {
        activiteTiles = new List<GameObject>();
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform; 
        
        for (int i=0; i < SafeArea; i++)
        {
            if (i < 2)
            {
                Spawner(0);
            }
            else
                Spawner();
        }

    }


    void Update()
    {
        if (playerTrans.position.z - SafeTime > (spawnz - SafeArea * tileLength))
        {
            Spawner();
            DeleteTile();
        }
    }

    private void Spawner(int SafeArea = -1)
    {
        GameObject go;

        if (SafeArea == -1)
        {
            go = Instantiate(tilePrefabs[RandomPref()]) as GameObject;
        }
        else
        {
            go = Instantiate(tilePrefabs[SafeArea]) as GameObject;
        }

      
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnz;
        spawnz += tileLength;
        activiteTiles.Add(go);
    }
    private void DeleteTile()
    {
        Destroy(activiteTiles[0]);
        activiteTiles.RemoveAt(0);

    }

    private int RandomPref()
    {
        if(tilePrefabs.Length <= 1)
        {
            return 0;
        }

        int randomIndex = lastPref;
        while(randomIndex == lastPref)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);

        }
        lastPref = randomIndex;
        return randomIndex;

    }


}
