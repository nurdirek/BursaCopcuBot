using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 4f)*Time.deltaTime);
        }
        
           
        

        else
        {
            animator.SetBool("isWalking", false);
        }
    }





}
