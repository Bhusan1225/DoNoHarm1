using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropsSpawnController : MonoBehaviour
{
    [SerializeField]
    private GameObject DropPrefab;

    [SerializeField]
    private Transform DropSpawnTransform;

    internal bool isDropThere;

    float delayNextDrop = 5f;


   
    void Update()
    {
        if (isDropThere == false)
        {
            Instantiate(DropPrefab, DropSpawnTransform.position, DropSpawnTransform.rotation);
            isDropThere = true;
            Invoke(nameof(DropThere), delayNextDrop);
        }

    }

    public void DropThere()
    {
        isDropThere = false;
    }
}
