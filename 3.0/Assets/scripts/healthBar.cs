using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider slider;
    public playerHealth script;
    void Start ()
    {
        script.currentHealth;
    }

public void SetHealth( script.currentHealth)
{
    slider.value = script.currentHealth;
}

    
    
    

}
