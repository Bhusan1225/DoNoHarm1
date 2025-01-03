using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedSpawning : MonoBehaviour


{

    //seed
    public Transform seedPrefab;
    public Vector2 SeedspawnAreaMin = new Vector2(-24, -12);
    public Vector2 SeedspawnAreaMax = new Vector2(24, 13);


    // Start is called before the first frame update
    void Start()
    {
        SpawnSeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSeed()
    {
        Vector2 randomPosition = new Vector2(
            Random.Range(SeedspawnAreaMin.x, SeedspawnAreaMax.x),
            Random.Range(SeedspawnAreaMin.y, SeedspawnAreaMax.y)
        );

        Instantiate(seedPrefab, randomPosition, Quaternion.identity);
    }
}
