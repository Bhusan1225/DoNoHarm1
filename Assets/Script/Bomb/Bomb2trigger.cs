using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb2trigger : MonoBehaviour
{
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {

            Debug.Log("bomb dropped");
          

            PlantController grassController = FindObjectOfType<PlantController>();
            if (grassController != null)
            {
                grassController.RemoveGrass(collision.transform);
            }
            Destroy(collision.gameObject);
            Destroy(gameObject);
            return;
        }

        if (collision.gameObject.CompareTag("Ground"))
        {

            Debug.Log("bomb dropped on Ground");
            
            Destroy(gameObject);
            return;
        }

        if (collision.gameObject.CompareTag("Tree"))
        {

            Debug.Log("bomb dropped on tree");

            Destroy(gameObject);
            return;
        }

        if (collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Bomb dropped on Protagonist, Health reduced");

            HealthController healtController = FindAnyObjectByType<HealthController>();
            healtController.Reduce();

            Destroy(gameObject);
            return;
        }

        if (collision.gameObject.CompareTag("Barrier"))
        {

            Debug.Log("bomb dropped on barrier");


            Destroy(gameObject);
            return;
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            HealthController healthController = FindAnyObjectByType<HealthController>();
            Debug.Log("Good target");
            healthController.Grow();

            Destroy(gameObject);
            return;
        }

    }
}
