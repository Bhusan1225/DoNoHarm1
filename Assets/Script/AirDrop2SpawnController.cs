using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDrop2SpawnController : MonoBehaviour
{
    public GameObject AirDrop2Prefab;

    public Transform AirDrop2SpawnTransform;

    internal bool isAirDrop2There;

    float delayNextAirDrop2 = 5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isAirDrop2There == false)
        {
            Instantiate(AirDrop2Prefab, AirDrop2SpawnTransform.position, AirDrop2SpawnTransform.rotation);
            isAirDrop2There = true;
            Invoke(nameof(AirDrop2There), delayNextAirDrop2);
        }

    }

    public void AirDrop2There()
    {
        isAirDrop2There = false;
    }
}
