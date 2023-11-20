using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation2 : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        bool isBicepCurl = animator.GetBool("isBC");
        bool isFrontRaises = animator.GetBool("isFR");
        bool isIdle = animator.GetBool("isIdle");

        bool bcPressed = Input.GetKey("b");
        bool frPressed = Input.GetKey("f");
        bool idlePressed = Input.GetKey("t");

        if (!isBicepCurl && bcPressed){
            animator.SetBool("isIdle", false);
            animator.SetBool("isBC", true);
        }

        if (isBicepCurl && idlePressed){
            animator.SetBool("isBC", false);
            animator.SetBool("isIdle", true);
        }

        if (!isFrontRaises && frPressed){
            animator.SetBool("isIdle", false);
            animator.SetBool("isFR", true);
        }

        if (isFrontRaises && idlePressed){
            animator.SetBool("isFR", false);
            animator.SetBool("isIdle", true);
        }
    }
}
