using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTrigger : MonoBehaviour
{
    bool ishearthtaken;
    private void Start()
    {
        StartCoroutine(DestroyHeart(5f));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You get one Health....");

            HealthController healthController = FindAnyObjectByType<HealthController>();

            healthController.Grow();
            ishearthtaken = true;
            Destroy(gameObject);
        }
    }


    private  IEnumerator DestroyHeart (float delay)
    {
        yield return new WaitForSeconds(delay);

        

        
        gameObject.SetActive(false);
        Destroy(gameObject,5);

        Invoke(nameof(CheckHeartTaken), 4f);

    }

    void CheckHeartTaken()
    {
        HeartSpawn healthSpawn = FindAnyObjectByType<HeartSpawn>();
        if (!ishearthtaken)
        {
            healthSpawn.noHeartThere();
        }
    }
}
