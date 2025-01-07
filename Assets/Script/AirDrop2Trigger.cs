using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDrop2Trigger : MonoBehaviour
{
    public AirDropEnum AirDropType;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Player collected the carate");
            AirDropManager DropManager = FindObjectOfType<AirDropManager>();

            DropManager.ActivatePowerUp(AirDropType);

            Destroy(gameObject);


        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("The crate is landed on the ground");
            Destroy(gameObject, 10);

        }

        if (collision.gameObject.CompareTag("Plant"))
        {
            Debug.Log("The crate is landed on the plant");


        }

        if (collision.gameObject.CompareTag("Animal"))
        {
            Debug.Log("The crate is landed on the ground");
            Destroy(gameObject, 5);

        }
    }
}


