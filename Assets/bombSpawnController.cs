using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawnController : MonoBehaviour
{
    public GameObject bombPrefab;

    public Transform BombSpawnTransform;

    internal bool isBombThere;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBombThere == false)
        {
            Instantiate(bombPrefab, BombSpawnTransform.position, BombSpawnTransform.rotation);
            isBombThere = true;
        }
        
    }

    public void BombThere()
    {
        isBombThere = false;
    }
}
