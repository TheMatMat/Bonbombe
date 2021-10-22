using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public GameObject candyPrefab, bombPrefab;
    public float spawnBound = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCandy", 1.0f, 1.5f);  
        InvokeRepeating("SpawnBomb", 1.5f, 1.5f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        //pick a random horizontal spawn position
        float randomX = Random.Range(- spawnBound, spawnBound);

        //instantiate candy prefab as child of item handler
        Instantiate(candyPrefab, this.gameObject.transform.position + new Vector3(randomX, 0, 0), Quaternion.identity, this.gameObject.transform);
    }

    void SpawnBomb()
    {
        //pick a random horizontal spawn position
        float randomX = Random.Range(-10.0f, 10.0f);

        //instantiate bomb prefab as child of item handler
        Instantiate(bombPrefab, this.gameObject.transform.position + new Vector3(randomX, 0, 0), Quaternion.identity, this.gameObject.transform);
    }
}
