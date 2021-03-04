using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    Rigidbody2D rb; 
    bool isGrounded = false; 
    public float jumpForce;
    public Transform isGroundedChecker; 
    public float checkGroundRadius; 
    public LayerMask groundLayer;
    public Animator animator;
    void Start()
    {
            rb = GetComponent<Rigidbody2D>(); 

    }
    void Update()
    {
        Jump();
        CheckIfGrounded();
    }
    void Jump() { 
    if (Input.GetKey(KeyCode.Space) && isGrounded || Input.touches.Length > 0 && isGrounded) { 
        rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
        animator.SetBool("isJumping",true);
    }
}
    


    void CheckIfGrounded() { 
    Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer); 
    if (collider != null) { 
        isGrounded = true; 
                animator.SetBool("isJumping",false);

    } else { 
        isGrounded = false; 
    } 


    
}

}


