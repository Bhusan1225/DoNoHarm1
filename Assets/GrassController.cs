using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassController : MonoBehaviour
{

    public List<Transform> grass;
    public Transform grassPrefab;


    void Start()
    {
        grass = new List<Transform>();
        grass.Add(this.transform);
    }
    public void GrowGrass()
    {

        if (grass.Count < 14)
        {
            Transform newGrass = Instantiate(this.grassPrefab);

            newGrass.position = grass[grass.Count - 1].position;

            grass.Add(newGrass);
        }
        else
        {
            Debug.Log("health is full...");
        }

    }
}
