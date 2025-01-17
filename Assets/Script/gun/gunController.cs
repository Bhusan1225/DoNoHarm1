using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 100f;
    private float minRotation = 0f;
    private float maxRotation = 180f;

    //bullet
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform gunTip;
    [SerializeField] private float bulletSpeed = 10000f;
    [SerializeField] private float DelayeDestroyBUllet = 5f;
    private bool isShooting;
    [SerializeField] private float Shootingdelay = 3f;

    //ray
    private float rayDistance = 50f;
    private LineRenderer lineRenderer;
   

    private float currentRotation = 0f;

    //attach script
    [SerializeField] private AirDropManager DropManager;


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

        setShootingInput();

        ShootRay();
    
    }


    public void setShootingInput()
    {
        if (DropManager.isMultipleShootOn == true)
        {
            multipleShootInputs();
        }
        else if (DropManager.isMultipleShootOn == false)
        {

            singleShootInputs();
        }
    }

    public void singleShootInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shootingdelay = 2f;
            ShootBullet();
        }
    }

    public void multipleShootInputs()
    {
        if (Input.GetMouseButton(0))
        {
            Shootingdelay = 0.1f;
            ShootBullet();
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
        if (bulletPrefab != null && gunTip != null && isShooting ==true)
        {
            GameObject bullet = Instantiate(bulletPrefab, gunTip.position, gunTip.rotation);
            Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

            if (bulletRb != null)
            {
                bulletRb.AddForce(gunTip.up * bulletSpeed, ForceMode2D.Impulse);
            }

            
        }
        isShooting = false;

        
        StartCoroutine((ActiveShooting(Shootingdelay)));
    }

    IEnumerator ActiveShooting(float Shootingdelay)
    {
        yield return new WaitForSeconds(Shootingdelay); 
        isShooting = true;

    }

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


