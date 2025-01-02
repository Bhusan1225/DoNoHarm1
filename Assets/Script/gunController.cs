using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{

    public float rotationSpeed = 100f;
    public float minRotation = 0f;
    public float maxRotation = 180f;

    //bullet
    public GameObject bulletPrefab;
    public Transform gunTip;
    public float bulletSpeed = 10000f;
    public float DelayeDestroyBUllet = 5f;

    //ray
    public float rayDistance = 50f;
    public LineRenderer lineRenderer;


    private float currentRotation = 0f;



    private void Start()
    {
        if (lineRenderer != null)
        {
            lineRenderer.positionCount = 2; 
        }
    }
    void Update()
    {
        GunRotation();

        if (Input.GetMouseButtonDown(0))
        {

            ShootBullet();
        }

        if (Input.GetMouseButton(1))
        {

            ShootRay();
        }

        
    }

    void GunRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");

        currentRotation += -mouseX * rotationSpeed * Time.deltaTime;
        currentRotation = Mathf.Clamp(currentRotation, minRotation, maxRotation);

        transform.localRotation = Quaternion.Euler(0f, 0f, currentRotation);


    }



    void ShootBullet()
    {
        if (bulletPrefab != null && gunTip != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, gunTip.position, gunTip.rotation);
            Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

            if (bulletRb != null)
            {
                bulletRb.AddForce(gunTip.up * bulletSpeed, ForceMode2D.Impulse);
            }

            //Invoke(nameof(destroyBullet), DelayeDestroyBUllet);
        }
    }

    //void destroyBullet()
    //{
    //    Destroy(bulletPrefab,5);
    //}

    void ShootRay()
    {
        if (gunTip != null && lineRenderer != null)
        {
            Ray ray = new Ray(gunTip.position, gunTip.up);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, rayDistance);

            lineRenderer.SetPosition(0, ray.origin);

            if (hit.collider != null)
            {
                lineRenderer.SetPosition(1, hit.point);
            }
            else
            {
                lineRenderer.SetPosition(1, ray.origin + ray.direction * rayDistance);
            }
        }
    }
}


