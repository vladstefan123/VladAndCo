using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    
    public int maxHealth=10;
    public int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    
public void TakeDamage(int damage)
{
    currentHealth -=damage;
    if(currentHealth <=0)
    {
        Destroy(gameObject);
    }
}
}