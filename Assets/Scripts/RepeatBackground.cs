using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    [HideInInspector] public float speed;
    private Vector3 startPosition;
    private float repeatWidth;
    public bool canMove;
    private RandomCoinSpawner randomCoinSpawner;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = gameObject.transform.position;
        repeatWidth = gameObject.GetComponent<BoxCollider2D>().size.x / 2;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        randomCoinSpawner = GameObject.FindObjectOfType<RandomCoinSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if (transform.position.x < startPosition.x - repeatWidth)
            {
                transform.position = startPosition;
                randomCoinSpawner.RandomCoinSetSpawner();
            }

            gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
