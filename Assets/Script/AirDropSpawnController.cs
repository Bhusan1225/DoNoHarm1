using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropSpawnController : MonoBehaviour
{
    public GameObject AirDropPrefab;

    public Transform AirDropSpawnTransform;

    internal bool isAirDropThere;

    float delayNextAirDrop = 5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
