using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombTriggerController : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {

            Debug.Log("bomb dropped");
            Destroy(collision.gameObject);
            


            //Destroy(gameObject, 10);
            Destroy(gameObject);
        }
    }


    
}
