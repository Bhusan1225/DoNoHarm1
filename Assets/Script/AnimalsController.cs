using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsController : MonoBehaviour
{
    public float patrolSpeed = 2f;
    public Vector3 pointA;
    public Vector3 pointB;
    private Vector3 targetPoint;
    private void Start()
    {
        SetPatrolPoints();
    }

    private void SetPatrolPoints()
    {
        transform.position = pointA;
        targetPoint = pointB;
    }
    private void Update()
    {

        PatrolAnimal();
    }
   

    private void PatrolAnimal()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, patrolSpeed * Time.deltaTime);
        if (transform.position == targetPoint)
        {
            targetPoint = (targetPoint == pointA) ? pointB : pointA;
        }
    }
}
