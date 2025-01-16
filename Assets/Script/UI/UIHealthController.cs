using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthController : MonoBehaviour
{
    [SerializeField] private Transform healthBarContainer;
    [SerializeField] private GameObject healthBarUIPrefab;
    internal List<RectTransform> healthBar;
    [SerializeField] internal int maxHealth = 19;

    void Start()
    {
        healthBar = new List<RectTransform>();
        RectTransform initialBar = this.gameObject.GetComponent<RectTransform>();
        healthBar.Add(initialBar);
    }

    public void Grow()
    {
        if (healthBar.Count < maxHealth)
        {
            GameObject newBar = Instantiate(healthBarUIPrefab, healthBarContainer);
            RectTransform newBarRect = newBar.GetComponent<RectTransform>();

            if (healthBar.Count == 1)
            {
                // Set initial position of the first health bar
                newBarRect.anchoredPosition = Vector2.zero;
            }
            else
            {
                RectTransform lastBarRect = healthBar[healthBar.Count - 1];
                Vector3 offset = new Vector3(lastBarRect.rect.width + 2f, 0f, 0f); // Adjust spacing as needed
                newBarRect.anchoredPosition = lastBarRect.anchoredPosition + new Vector2(offset.x, 0f);
            }

            healthBar.Add(newBarRect);
        }
        else
        {
            Debug.Log("Health is full...");
        }
    }

    public void Reduce()
    {
        if (healthBar.Count > 1)
        {
            RectTransform lastSegment = healthBar[healthBar.Count - 1];
            healthBar.RemoveAt(healthBar.Count - 1);
            Destroy(lastSegment.gameObject);
        }
        else
        {
            Debug.Log("GAME OVER");
        }
    }


}

