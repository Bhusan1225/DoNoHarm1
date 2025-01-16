using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropSpawnController : MonoBehaviour
{
    [SerializeField]
    private GameObject AirDropPrefab;

    [SerializeField]
    private Transform AirDropSpawnTransform;

    internal bool isAirDropThere;

    float delayNextAirDrop = 5f;


   
    void Update()
    {
        if (isAirDropThere == false)
        {
            Instantiate(AirDropPrefab, AirDropSpawnTransform.position, AirDropSpawnTransform.rotation);
            isAirDropThere = true;
            Invoke(nameof(AirDropThere), delayNextAirDrop);
        }

    }

    public void AirDropThere()
    {
        isAirDropThere = false;
    }
}
