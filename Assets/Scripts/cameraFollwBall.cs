using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollwBall : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private GameObject ball;
    [HideInInspector] public bool ballTrigger = false;
    private bool doOnce = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballTrigger)
        {
            if (!doOnce)
            {
                ball = GameObject.FindGameObjectWithTag("Ball");
                doOnce = true;
            }
            mainCamera.transform.position = new Vector3(ball.transform.position.x, 0f, -10);
        }
    }
}
