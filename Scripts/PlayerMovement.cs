using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float jumpPower = 15.0f;
    Rigidbody2D myrb;
    public bool isGrounded = true;
    public bool crouches;
    public bool jumps;
    public bool isJump = false;
    public Animator anim;


     
    // Start is called before the first frame update
    void Start()
    {
        myrb = transform.GetComponent<Rigidbody2D>();
        PlayerPrefs.SetInt("speed", 5);
        anim = GetComponent<Animator>();
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Level2")
        {
            PlayerPrefs.SetInt("speed", 8);
            jumpPower = 20.0f;
        }

        if (sceneName == "Level4")
        {
            PlayerPrefs.SetInt("speed", 6);
            jumpPower = 18.0f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        crouches = Input.GetButton("Slide");
        jumps = Input.GetButton("Jump");
        
        transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
        

        if (jumps && isGrounded)
        {
            myrb.AddForce(Vector3.up * (jumpPower * myrb.mass * myrb.gravityScale * 10.0f));
            
        }

        if(!isGrounded)
        {
            anim.Play("Jump");
        
        }

        if(crouches && !isGrounded)
        {
            anim.Play("CrouchJump");
        }


        if (crouches)
        {
            anim.Play("Crouch");
        }
        else if(isGrounded)
        {
            anim.Play("RunningLoop");
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;

        }

      


    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = true;
        }

        foreach (ContactPoint2D hitPos in other.contacts)
        {
            if (hitPos.normal.x != 0) // check if the wall collided on the sides
                isGrounded = false; 
            else if (hitPos.normal.y > 0) // check if its collided on top 
            {   
                isGrounded = true;
                
            }
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Platform")
        {
            isGrounded = false;
        }
    }

    

}
