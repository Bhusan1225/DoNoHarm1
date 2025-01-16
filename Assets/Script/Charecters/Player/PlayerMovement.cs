using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //player walk
    [SerializeField]private float playerSpeed;

    //player jump
    [SerializeField]private float JumpHeight;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
        playerjump();
    }

    void playerMovement()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        Vector2 position = transform.position;
        position.x += playerSpeed * xMove * Time.deltaTime;

        transform.position = position;


    }
        void playerjump()
    {
       
       float vertical = Input.GetAxisRaw("Jump");

        
       if (vertical > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(new Vector2(0, JumpHeight), ForceMode2D.Impulse);
        }
            

    }
    

}
