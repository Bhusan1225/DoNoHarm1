using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlantController : MonoBehaviour
{

    public List<Transform> Plant;
    public Transform PlantPrefab;
    public TextMeshProUGUI plantCount_text;
     Quaternion PlantSpawnRotation = Quaternion.identity;

    


    //randomize
    public Vector2 spawnAreaMin = new Vector2(-24, -12);
    public Vector2 spawnAreaMax = new Vector2(24, 13);

   


    void Start()
    {
        Plant = new List<Transform>();
        Plant.Add(this.transform);

        for (int i = 1; i < 8; i++)
        {
            SpawnPlant();
        }

        //UpdatePlantCountUI();
        //SpawnSeed();

        
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

    private void UpdatePlantCountUI()
    {
        plantCount_text.text = "Plants: " + Plant.Count;
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

 
}
