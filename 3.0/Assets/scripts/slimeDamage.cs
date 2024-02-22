using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public int damage;
    public playerHealth playerHealth1;
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MARIUS")
        {
            playerHealth1.TakeDamage(damage);

        }
    }
}
