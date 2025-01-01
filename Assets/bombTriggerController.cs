using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombTriggerController : MonoBehaviour
{

    float delayNextBomb = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {

            Debug.Log("bomb dropped");
            Destroy(collision.gameObject);
            Invoke(nameof(DestroyBomb), delayNextBomb);


            //Destroy(gameObject, 10);

        }
    }


    void DestroyBomb()
    {

        bombSpawnController bombTrigger = FindAnyObjectByType<bombSpawnController>();
        bombTrigger.BombThere();
        
        Destroy(gameObject);
        
    }
}
