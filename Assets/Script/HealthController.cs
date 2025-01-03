using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.HableCurve;

public class HealthController : MonoBehaviour
{

    //health bar
    public List<Transform> healthBar;
    public Transform healthBarPrefab;


    // Start is called before the first frame update
    void Start()
    {
        healthBar = new List<Transform>();
        healthBar.Add(this.transform);
    }

   

    public void Grow()
    {

        if(healthBar.Count < 14)
        {
            Transform bar = Instantiate(this.healthBarPrefab);
            Vector3 spaceBetweenBar = new Vector3(0.15f, 0f, 0f);
            bar.position = healthBar[healthBar.Count - 1].position + spaceBetweenBar;

            healthBar.Add(bar);
        }
        else
        {
            Debug.Log("health is full...");
        }
        
    }

    public void reduce()
    {

        if (healthBar.Count > 1)
        {

            Transform lastSegment = healthBar[healthBar.Count - 1];

            healthBar.RemoveAt(healthBar.Count - 1);


            Destroy(lastSegment.gameObject);
        }
        else
        {
            Debug.Log("GAME OVER");
            //gameOver UI


        }
    }
}
