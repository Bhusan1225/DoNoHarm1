using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Player collected the carate");
            Destroy(gameObject);


        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("The crate is landed on the ground");
            Destroy(gameObject, 2);

        }
        
        if (collision.gameObject.CompareTag("Plant"))
        {
            Debug.Log("The crate is landed on the plant");
           

        }
    }
}
