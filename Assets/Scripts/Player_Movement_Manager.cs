using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Manager : MonoBehaviour
{
    private GameObject player;
    private Animator playerAnim;
    private CircleCollider2D collider;
    [SerializeField] private float jumpForce = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerJumpIn()
    {
        player = GameObject.FindGameObjectWithTag("Ball");
        playerAnim = player.GetComponent<Animator>();
        playerAnim.SetBool("CanJump", true);
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x, jumpForce);
    }

    public void PlayerJumpOut()
    {
        player = GameObject.FindGameObjectWithTag("Ball");
        playerAnim = player.GetComponent<Animator>();
        playerAnim.SetBool("CanJump", false);
    }

    public void PlayerSlideIn()
    {
        player = GameObject.FindGameObjectWithTag("Ball");
        playerAnim = player.GetComponent<Animator>();
        collider = player.GetComponent<CircleCollider2D>();
        collider.radius = 1.7f;
        playerAnim.SetBool("CanSlide", true);
        
    }

    public void PlayerSlideOut()
    {
        player = GameObject.FindGameObjectWithTag("Ball");
        playerAnim = player.GetComponent<Animator>();
        collider = player.GetComponent<CircleCollider2D>();
        collider.radius = 2.3f;
        playerAnim.SetBool("CanSlide", false);
    }
}
