using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HeartSpawn : MonoBehaviour
{
    public GameObject heart;
    public Transform heartSpawnPoint;

    //scripts
    public PlantController plantController;

    public float spawnInterval = 5f;
   
    private bool isHeartActive = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HeartSpawnRoutine());
    }

    private IEnumerator HeartSpawnRoutine()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(spawnInterval);

            
            if (!isHeartActive && plantController.Plant != null && plantController.Plant.Count > 2)
            {
                SpawnHeart();
            }
        }
    }

    // Update is called once per frame
    void SpawnHeart()
    {
        Instantiate(heart, heartSpawnPoint.position, heartSpawnPoint.rotation);
        isHeartActive = true;
    }

    public void NotifyHeartTaken()
    {
        isHeartActive = false;
    }
}
