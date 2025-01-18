using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
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

    //attached Scripts
    [SerializeField] private GunController gunControl;

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

            gunControl.setShootingInput();
            MultipleShootBatch.SetActive(true);

           StartCoroutine(deactivateMultipleShoot(deactivationMultipleShotTime));
        }
    }

    IEnumerator deactivateMultipleShoot(float deactivationMultipleShotTime)
    {
        yield return new WaitForSeconds(deactivationMultipleShotTime);
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

            StartCoroutine(deactivateBarrier(deactivationBarrierTime));
            
        }
    }

    IEnumerator deactivateBarrier(float deactivationBarrierTime)
    {
        yield return new WaitForSeconds(deactivationBarrierTime);
        isBarrierOn = false;
        Barrier.SetActive(false);
        BarrierBatch.SetActive(false);
    }

}
