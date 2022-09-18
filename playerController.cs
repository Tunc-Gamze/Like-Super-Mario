using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
 
    Rigidbody2D playerRB;
    Animator playerAnimator;
    public float moveSpeed=1f;
    bool facingRight=true;


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
       if(playerRB.velocity.x<0 && facingRight )
       {
        FlipFace();
       }
       else if(playerRB.velocity.x>0 && !facingRight)
       {
        FlipFace();
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
}
