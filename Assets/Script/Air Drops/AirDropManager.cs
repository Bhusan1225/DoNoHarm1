using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropManager : MonoBehaviour
{

    internal bool isMultipleShootOn;
    internal bool isBarrierOn;

    [SerializeField]private GameObject Barrier;
    
    [SerializeField]private float deactivationMultipleShotTime = 5f;
    [SerializeField]private float deactivationBarrierTime = 6f;

    //batch
    [SerializeField]private GameObject BarrierBatch;
    [SerializeField]private GameObject MultipleShootBatch;

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

            GunController gunControl = FindAnyObjectByType<GunController>();

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
