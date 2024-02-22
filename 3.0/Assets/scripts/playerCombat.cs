using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class playerCombat : MonoBehaviour
{
    
public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        
            Attack();
            else
            
                animator.SetBool("isAttacking", false);
            
        
        
    }
    void Attack()
    {
        animator.SetBool("isAttacking", true);
    }
}
