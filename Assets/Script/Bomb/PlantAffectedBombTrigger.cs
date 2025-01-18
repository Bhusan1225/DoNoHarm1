using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantAffectedBombTrigger : MonoBehaviour
{

    private PlantController plantController;
    private UIHealthController healthController;

    private void Start()
    {
        plantController = FindAnyObjectByType<PlantController>();
        healthController = FindAnyObjectByType<UIHealthController>();
 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {

            Debug.Log("bomb dropped");
          

           
            if (plantController != null)
            {
                plantController.RemoveGrass(collision.transform);
            }
            Destroy(collision.gameObject);
            Destroy(gameObject);
            return;
        }

        else if (collision.gameObject.CompareTag("Ground"))
        {

            Debug.Log("bomb dropped on Ground");
            
            Destroy(gameObject);
            return;
        }

        else if (collision.gameObject.CompareTag("Tree"))
        {

            Debug.Log("bomb dropped on tree");

            Destroy(gameObject);
            return;
        }

        else if (collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Bomb dropped on Protagonist, Health reduced");


            healthController.Reduce();

            Destroy(gameObject);
            return;
        }

        else if (collision.gameObject.CompareTag("Barrier"))
        {

            Debug.Log("bomb dropped on barrier");


            Destroy(gameObject);
            return;
        }

        else if (collision.gameObject.CompareTag("Bullet"))
        {
            
            Debug.Log("Good target");
            healthController.Grow();

            Destroy(gameObject);
            return;
        }

    }
}
