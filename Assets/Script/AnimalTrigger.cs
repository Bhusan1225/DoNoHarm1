using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            Debug.Log("Animal garaze your Plants");
            Destroy(collision.gameObject);
        }
    }
}
