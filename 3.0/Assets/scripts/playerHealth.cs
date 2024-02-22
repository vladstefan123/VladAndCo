using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour
{
   
   
    public int maxHealth=10;
    public int currentHealth;
    public healthbar healthBar;
    void Start()
    {
       
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
       
    }
    
public void TakeDamage(int damage)
{

    currentHealth-=damage;
    healthBar.SetHealth(currentHealth);
    if(currentHealth <=0)
    {
        Destroy(gameObject);
    }
}
}