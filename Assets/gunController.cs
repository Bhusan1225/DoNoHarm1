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
    
   
    private float currentRotation = 0f;

    void Update()
    {
        GunRotation();

       


    }

    void GunRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");
        
        currentRotation += -mouseX * rotationSpeed * Time.deltaTime;
        currentRotation = Mathf.Clamp(currentRotation, minRotation, maxRotation);

        transform.localRotation = Quaternion.Euler(0f, 0f, currentRotation);

        if (Input.GetKeyDown(KeyCode.G))
        {
            
            ShootBullet();
        }
    }

    

    void ShootBullet()
    {
        if (bulletPrefab != null && gunTip != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, gunTip.position, gunTip.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();

            if (bulletRb != null)
            {
                bulletRb.velocity = gunTip.forward * bulletSpeed;
            }
        }
    }
}



