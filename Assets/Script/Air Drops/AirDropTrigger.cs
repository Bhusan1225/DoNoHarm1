using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropTrigger : MonoBehaviour
{
    [SerializeField]
    private AirDropEnum AirDropType;

    private AirDropManager dropManager;


   void Start()
    {
        
        dropManager = FindObjectOfType<AirDropManager>();

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Player collected the carate");
      
            dropManager.ActivatePowerUp(AirDropType);

            Destroy(gameObject);

        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("The crate is landed on the ground");
            Destroy(gameObject, 2);

        }
   
    }
}
