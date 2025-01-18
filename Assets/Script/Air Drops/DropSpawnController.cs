using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSpawnController : MonoBehaviour
{
    [Header("Drop Spawn ")]
    [SerializeField]
    private GameObject DropPrefab;

    [SerializeField]
    private Transform DropSpawnTransform;

    internal bool isDropThere;

    private float delayNextDrop = 5f;

    void Update()
    {

        DropSpawn();
       

    }

    void DropSpawn()
    {
        if (isDropThere == false)
        {
            Instantiate(DropPrefab, DropSpawnTransform.position, DropSpawnTransform.rotation);
            isDropThere = true;

            StartCoroutine(DropThere(delayNextDrop));
        }
    }

   IEnumerator DropThere(float delayNextDrop)
    {
        yield return new WaitForSeconds(delayNextDrop);
        isDropThere = false;
    }
}
