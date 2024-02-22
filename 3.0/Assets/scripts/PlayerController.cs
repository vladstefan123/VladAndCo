using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerControllerTutorialUpdates : MonoBehaviour
{
 
    public float speed;

    
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {   
        animator = GetComponent<Animator>();
    }
       



      
    


    // Update is called once per frame
    void Update()
    {
        var rotationVector = transform.rotation.eulerAngles;
        float horizontal = 0.0f;
        Quaternion rotation = transform.rotation;
        if (Keyboard.current.aKey.isPressed)
        {
            horizontal = -1.0f;
            animator.SetBool("isMoving", true);
            animator.SetBool("isGoingUp", false);
            animator.SetBool("isGoingDown", false);
            animator.SetBool("isGoingHorizontally", true);

            rotationVector.y = 180;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            horizontal = 1.0f;
            animator.SetBool("isMoving", true);
            animator.SetBool("isGoingUp", false);
            animator.SetBool("isGoingDown", false);
            animator.SetBool("isGoingHorizontally", true);

            rotationVector.y = 0;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
        Debug.Log(horizontal);


        float vertical = 0.0f;
        if (Keyboard.current.wKey.isPressed)
        {
            vertical = 1.0f;
            animator.SetBool("isMoving", true);
            animator.SetBool("isGoingUp", true);
            animator.SetBool("isGoingDown", false);
            animator.SetBool("isGoingHorizontally", false);

        }
        else if (Keyboard.current.sKey.isPressed)
        {
            vertical = -1.0f;
            animator.SetBool("isMoving", true);
            animator.SetBool("isGoingUp", false);
            animator.SetBool("isGoingDown", true);
            animator.SetBool("isGoingHorizontally", false);
        }
        Debug.Log(vertical);

    if( !(Keyboard.current.wKey.isPressed)& !(Keyboard.current.sKey.isPressed) & !(Keyboard.current.dKey.isPressed) & !(Keyboard.current.aKey.isPressed))
        {
            animator.SetBool("isMoving", false);
        }
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal;
        position.y = position.y + speed * vertical;
        transform.position = position;
        if (animator.GetBool("isDead"))
        {
            speed=0;
        }
    }
    


}