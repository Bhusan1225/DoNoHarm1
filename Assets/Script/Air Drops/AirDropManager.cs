using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropManager : MonoBehaviour
{

    public bool isMultipleShootOn;
    public bool isBarrierOn;

    public GameObject Barrier;

    public float deactivationMultipleShotTime = 5f;
    public float deactivationBarrierTime = 6f;

    //batch
    public GameObject BarrierBatch;
    public GameObject MultipleShootBatch;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ActivatePowerUp(AirDropEnum AirDropType)
    {
        switch (AirDropType)
        {
            case AirDropEnum.MultipleShootDrop:
                ActivateMultipleShoot();
                break;
            case AirDropEnum.BarrierDrop:
                ActivateBarrier();
                break;

        }
    }

    void ActivateMultipleShoot()
    {
        if (isMultipleShootOn== false)
        {
            isMultipleShootOn = true;

            gunController gunControl = FindAnyObjectByType<gunController>();

            gunControl.setShootingInput();
            MultipleShootBatch.SetActive(true);

            Invoke(nameof(deactivateMultipleShoot), deactivationMultipleShotTime);

        }
    }

    void deactivateMultipleShoot()
    {
        isMultipleShootOn = false;
        MultipleShootBatch.SetActive(false);
    }

    void ActivateBarrier()
    {
        if(!isBarrierOn)
        {
            isBarrierOn = true;
            Barrier.SetActive(true);
            BarrierBatch.SetActive(true);

            Invoke(nameof(deactivateBarrier), deactivationBarrierTime);
        }
    }

    void deactivateBarrier()
    {
        isBarrierOn = false;
        Barrier.SetActive(false);
        BarrierBatch.SetActive(false);
    }

}
