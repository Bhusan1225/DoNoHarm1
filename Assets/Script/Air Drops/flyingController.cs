using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingController : MonoBehaviour
{
    [SerializeField]
    private float patrolSpeed = 2f;
    [SerializeField]
    private Vector3 pointA, pointB;
    
    private Vector3 targetPoint;

    void Start()
    {
        setPetrolPoint();

    }
    void setPetrolPoint()
    {
       transform.position = pointA;
       targetPoint = pointB  ;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, patrolSpeed * Time.deltaTime);

        if (transform.position == targetPoint)
        {
            targetPoint = (targetPoint == pointA) ? pointB : pointA;
        }
    }
}
