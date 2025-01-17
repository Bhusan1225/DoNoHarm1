using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedSpawnController : MonoBehaviour
{

    [Header("Seed Spawn ")]
    //seed
    [SerializeField] private GameObject seedPrefab;
    [SerializeField] private Vector2 SeedSpawnAreaMin = new Vector2(-24, -12);
    [SerializeField] private Vector2 SeedSpawnAreaMax = new Vector2(24, 13);

    [SerializeField]
    private float delayNextSeed = 8f;

    internal bool isSeedThere;

    void Update()
    {

        
        RandomSeedSpawn();

    }

    public void RandomSeedSpawn()
    {

        if (!isSeedThere)
        {
            Vector2 randomPosition = new Vector2(
           Random.Range(SeedSpawnAreaMin.x, SeedSpawnAreaMax.x),
           Random.Range(SeedSpawnAreaMin.y, SeedSpawnAreaMax.y)
       );


            isSeedThere = true;
            Instantiate(seedPrefab, randomPosition, Quaternion.identity);
            StartCoroutine(SeedThere(delayNextSeed));
        }

    }

    IEnumerator SeedThere(float delayNextSeed)
    {
        yield return new WaitForSeconds(delayNextSeed);
        isSeedThere = false;
    }
}
