using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HeartSpawn : MonoBehaviour
{
    public GameObject heart;
    public Transform heartTransform;

    //scripts
    public PlantController plantController;


    bool isHeartThere = false;


    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!isHeartThere && plantController.Plant != null && plantController.Plant.Count > 2)
        {
            
            Instantiate(heart, heartTransform.position, heartTransform.rotation);
            isHeartThere = true;

        }


    }

    public void noHeartThere()
    {
        isHeartThere = false;
    }
}
