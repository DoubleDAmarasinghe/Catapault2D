using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private int hitCount = 0;
    [SerializeField] private PhysicsMaterial2D lowBouncePM2D;
    [SerializeField] private Sprite manSprite;
    [SerializeField] private Rigidbody2D rb;
    private bool doOnce = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hitCount == 3)
        {
            if (doOnce)
            {
                Quaternion newRotation = Quaternion.Euler(0f, 0f, 0f);
                gameObject.GetComponent<CircleCollider2D>().sharedMaterial = lowBouncePM2D;
                gameObject.GetComponent<SpriteRenderer>().sprite = manSprite;
                gameObject.transform.rotation = newRotation;
                gameObject.GetComponent<Animator>().SetTrigger("CanRun");
                gameObject.GetComponent<CircleCollider2D>().radius = 2.3f;
                GameObject.FindAnyObjectByType<cameraFollwBall>().ballTrigger = false;
                doOnce = false;
            }
            
            
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" && hitCount != 3)
        {
            hitCount += 1;
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            
            Debug.Log("Ground Touch : " + hitCount);
            Debug.Log("Ball : Freez Possition X");
        }
    }
}
