using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlantController : MonoBehaviour
{

    [SerializeField] private List<Transform> Plant;
    [SerializeField] private Transform PlantPrefab;
    [SerializeField] private TextMeshProUGUI plantCount_text;
    private Quaternion PlantSpawnRotation = Quaternion.identity;

    //randomize
    [SerializeField] private Vector2 spawnAreaMin = new Vector2(-24, -12);
    [SerializeField] private Vector2 spawnAreaMax = new Vector2(24, 13);

    void Start()
    {
        Plant = new List<Transform>();
        Plant.Add(this.transform);

        for (int i = 1; i < 10; i++)
        {
            SpawnPlant();
        }

      }

    private void Update()
    {
        UpdatePlantCountUI();
    }
    public void SpawnPlant()
    {

            Vector2 randomPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
            );

            Transform newGrass = Instantiate(PlantPrefab, randomPosition, PlantSpawnRotation);

            Plant.Add(newGrass);
  
    }

    public void RemoveGrass(Transform grassTransform)
    {
        if (Plant.Contains(grassTransform))
        {
            Plant.Remove(grassTransform);
            Debug.Log("Plant removed. Remaining plants: " + Plant.Count);
            UpdatePlantCountUI();
        }
    }


    public void AddGrassFromSeed()
    {
        
        Vector2 randomPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        Transform newGrass = Instantiate(PlantPrefab, randomPosition, PlantSpawnRotation);
        Plant.Add(newGrass);

        UpdatePlantCountUI(); 
    }

    private void UpdatePlantCountUI()
    {
        plantCount_text.text = "Plants: " + Plant.Count;
    }

}
