using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{
    public GameObject bombPrefab;

    public Transform BombSpawnTransform;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bombPrefab, BombSpawnTransform.position, BombSpawnTransform.rotation);
    }
}
