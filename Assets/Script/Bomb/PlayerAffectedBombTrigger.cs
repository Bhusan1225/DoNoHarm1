using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAffectedBombTrigger : MonoBehaviour
{


    private UIHealthController healthController;

    private void Start()
    {
        healthController = FindAnyObjectByType<UIHealthController>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        if ( collision.gameObject.CompareTag("Ground"))
        {

            Debug.Log("bomb dropped on Ground");

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


    }


    
}
