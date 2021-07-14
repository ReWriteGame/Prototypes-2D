using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBarVisual : MonoBehaviour
{
    [SerializeField] private LifeBar LifeBar;


    [SerializeField] private List<GameObject> healthPoint;
    void Start()
    {
        StartCoroutine(checkHealth());
    }

    private IEnumerator checkHealth()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            for (int i = LifeBar.Health; i < healthPoint.Count; i++)
                healthPoint[i].SetActive(false);
        }
    }
}
