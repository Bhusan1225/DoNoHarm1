using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You are standing on the Plants");
            Destroy(gameObject);
        }
    }
}
