using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HeartSpawnController : MonoBehaviour
{

    [SerializeField] private GameObject heart;
    [SerializeField] private Transform heartSpawnPoint;
    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private float heartCooldown = 10f;
    [SerializeField] private PlantController plantController;

    private bool isHeartActive = false;
    private float spawnTimer;
    private float cooldownTimer;


    //void Start()
    //{
    //    StartCoroutine(HeartSpawnRoutine());
    //}

    //private IEnumerator HeartSpawnRoutine()
    //{
    //    while (true)
    //    {

    //        yield return new WaitForSeconds(spawnInterval);


    //        if (!isHeartActive && plantController.Plant != null && plantController.Plant.Count > 2)
    //        {
    //            SpawnHeart();
    //        }
    //    }
    //}

    //// Update is called once per frame
    //void SpawnHeart()
    //{
    //    Instantiate(heart, heartSpawnPoint.position, heartSpawnPoint.rotation);
    //    isHeartActive = true;
    //}

    //public void NotifyHeartTaken()
    //{
    //    isHeartActive = false;
    //}

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        cooldownTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0f;
            TrySpawnHeart();
        }
    }

    private void TrySpawnHeart()
    {
        if (!isHeartActive && cooldownTimer >= heartCooldown && plantController.Plant != null && plantController.Plant.Count > 2)
        {
            SpawnHeart();
        }
    }

    private void SpawnHeart()
    {
        Instantiate(heart, heartSpawnPoint.position, heartSpawnPoint.rotation);
        isHeartActive = true;
        cooldownTimer = 0f;
    }

    public void NotifyHeartTaken()
    {
        isHeartActive = false;
    }
}



