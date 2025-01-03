using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDropManager : MonoBehaviour
{

    public bool isMultipleShootOn;
    public bool isBarrierOn;

    public GameObject Barrier;

    float deactivationTime = 5f;
    float deactivationBarrierTime = 6f;


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

            Invoke(nameof(deactivateMultipleShoot), deactivationTime);

        }
    }

    void deactivateMultipleShoot()
    {
        isMultipleShootOn = false;
    }

    void ActivateBarrier()
    {
        if(!isBarrierOn)
        {
            isBarrierOn = true;
            Barrier.SetActive(true);

            Invoke(nameof(deactivateBarrier), deactivationBarrierTime);
        }
    }

    void deactivateBarrier()
    {
        Barrier.SetActive(false);
    }

}
