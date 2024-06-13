using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Rigidbody rb;

    public Animator animator;
    // Start is called before thefirst frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 v = rb.velocity;
        float stick = Input.GetAxis("Horizontal");
        float Speed = 3;
        float Jump = 5;

    //if(Input.GetKeyDown(KeyCode.UpArrow))
    //    {
    //        animator.SetBool("mode", true);
    //    }
    //if(Input.GetKeyDown(KeyCode.DownArrow))
    //    {
    //        animator.SetBool("mode", false);
    //    }


        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    Vector3 velocity = new Vector3(0, 0, 0.02f);
        //    transform.position += transform.rotation * velocity;
        //    animator.SetBool("mode", true);
        //}
        //else
        //{
        //    animator.SetBool("mode", false);
        //}
        //    if (Input.GetKey(KeyCode.RightArrow))
        //    {
        //        Vector3 worldAngle = transform.eulerAngles;
        //        worldAngle.y += 1.0f;
        //        transform.eulerAngles = worldAngle;
        //    }
        //    if (Input.GetKey(KeyCode.LeftArrow))
        //    {
        //        Vector3 worldAngle = transform.eulerAngles;
        //        worldAngle.y -= 1.0f;
        //        transform.eulerAngles = worldAngle;
        //    }
        
        

        if(stick>0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            v.x = Speed;
            animator.SetBool("mode", true);
        }
        else if (stick < 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
            v.x = -Speed;
            animator.SetBool("mode", true);
        }
        else
        {
            v.x = 0;
            animator.SetBool("mode", false);
        }
        

        if(Input.GetButtonDown("Jump"))
        {
            v.y = Jump;
            animator.SetBool("Jump",true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }
        rb.velocity = v;
    }
}
