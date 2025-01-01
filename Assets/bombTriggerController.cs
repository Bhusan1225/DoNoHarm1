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
      
            Destroy(gameObject,2f);
            return;
        }

        if ( collision.gameObject.CompareTag("Ground"))
        {

            Debug.Log("bomb dropped on Ground");

            Destroy(gameObject,2f);
            return;
        }


    }


    
}
