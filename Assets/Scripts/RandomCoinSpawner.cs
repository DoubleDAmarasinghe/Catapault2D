using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] coinContainers;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomCoinSetSpawner()
    {
        int randomIndex = Random.Range(0, coinContainers.Length);
        foreach(GameObject coinContainer in coinContainers)
        {
            coinContainer.SetActive(false);
        }
        coinContainers[randomIndex].SetActive(true);
        for (int i = 0; i < coinContainers[randomIndex].transform.childCount; i++)
        {
            // Get a reference to each child Transform
            Transform childTransform = coinContainers[randomIndex].transform.GetChild(i);
            childTransform.gameObject.SetActive(true);
            // Do something with the child Transform or GameObject
            Debug.Log("Child name: " + childTransform.name);
        }
    }
}
