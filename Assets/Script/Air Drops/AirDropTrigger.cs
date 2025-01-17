using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropTrigger : MonoBehaviour
{
    [SerializeField]
    private AirDropEnum AirDropType;
    
    //[SerializeField]private AirDropManager DropManager;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Player collected the carate");
            AirDropManager DropManager = FindObjectOfType<AirDropManager>();

            DropManager.ActivatePowerUp(AirDropType);

            Destroy(gameObject);


        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("The crate is landed on the ground");
            Destroy(gameObject, 2);

        }
   
    }
}
