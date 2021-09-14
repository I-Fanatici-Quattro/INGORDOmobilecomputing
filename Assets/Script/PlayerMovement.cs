using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    private float screenWidth;
    bool jump = false;
    public float speed = 0.8f;
    Score vita;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetFloat("Speed", 0.08f); //il player inizia con animazione Run_02
        screenWidth = Screen.width;
        vita = gameObject.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
                Touch touch = Input.GetTouch(0);
                jump = true;
                animator.SetBool("isJumping", true);
        }
        
        if (vita.health < 51) {
            speed = 0.2f;
            animator.SetFloat("Speed", speed);
        }

        if (vita.health > 51)
        {
            speed = 0.8f;
            animator.SetFloat("Speed", speed);
        }
    }

    //Move our character
    void FixedUpdate()
    {
        controller.Move(0,false,jump);
        jump = false;
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
        animator.SetFloat("Speed", speed);
    }

}
