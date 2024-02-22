using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class playerHealth : MonoBehaviour
{
   
    public int maxHealth=10;
    public int currentHealth;
    public GameOverScreen gameOverScreen;
    public Animator animator;
    void Start()
    {
        currentHealth = maxHealth;
    }
    
public void TakeDamage(int damage)
{

    currentHealth-=damage;
    if(currentHealth <=0)
    {
        animator.SetBool("isDead", true);
        gameOverScreen.Setup();
    }
}
}