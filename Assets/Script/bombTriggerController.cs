using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombTriggerController : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Plant") )
        {

            Debug.Log("bomb dropped");
            Destroy(collision.gameObject);
      
            Destroy(gameObject);
            return;
        }

        if ( collision.gameObject.CompareTag("Ground"))
        {

            Debug.Log("bomb dropped on Ground");

            Destroy(gameObject);
            return;
        }

        if (collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Bomb dropped on Protagonist, Health reduced");
            HealthController healtController = FindAnyObjectByType<HealthController>();
            healtController.reduce();

            Destroy(gameObject);
            return;
        }


    }


    
}
