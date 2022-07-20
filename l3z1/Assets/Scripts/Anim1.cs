using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Anim1 : MonoBehaviour
{
    public int animationReplyCount = 30;
    public Animator animator;
    private void Start()
    { 
        animator = GetComponent<Animator>();
    }
    public void AnimationPartEnd()
    { 
        
        while (animationReplyCount >= 0) 
        { 
            animationReplyCount--; 
            Debug.Log(animationReplyCount);
            animator.Play("animation1"); 
        }
    }
}
