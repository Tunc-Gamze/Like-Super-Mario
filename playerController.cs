using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
 
    Rigidbody2D playerRB;
    Animator playerAnimator;
    public float moveSpeed=1f;
    public float jumpSpeed = 1f, jumpFrequensy=1f ,nextJumpTime;

    bool facingRight=true;
    public bool isGrounded = false;

    public Transform groundCheckPosition;
    public float groundCheckRadius;
    public LayerMask groundCheckLayer;

    void Awake()
    {

    }
    void Start()
    {
        playerRB=GetComponent<Rigidbody2D>();
        playerAnimator=GetComponent<Animator>();
    }

    
    void Update()
    {
        
       HorizontalMove();
       OnGroundCheck();
        if (playerRB.velocity.x<0 && facingRight )
       {
        FlipFace();
       }
       else if(playerRB.velocity.x>0 && !facingRight)
       {
        FlipFace();
       }

       if (Input.GetAxis("Vertical")>0 && isGrounded && (nextJumpTime < Time.timeSinceLevelLoad) )
        {
            nextJumpTime = Time.timeSinceLevelLoad + jumpFrequensy;
            Jump();
        }
    }
    void FixedUpdate()
    {

    }
    void HorizontalMove()
    {
        playerRB.velocity=new Vector2(Input.GetAxis("Horizontal")*moveSpeed,playerRB.velocity.y);
        playerAnimator.SetFloat("playerSpeed",Mathf.Abs(playerRB.velocity.x));

    }
    

    void FlipFace()
    {
        facingRight=!facingRight;
        Vector3 temLocalScale=transform.localScale;
        temLocalScale.x*=-1;
        transform.localScale=temLocalScale;
    }


    void Jump()
    {
        playerRB.AddForce(new Vector2(0f, jumpSpeed));
    }

    void OnGroundCheck()
    {
        isGrounded=Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, groundCheckLayer);
        playerAnimator.SetBool("isGrondedAnim", isGrounded);
    }
}
