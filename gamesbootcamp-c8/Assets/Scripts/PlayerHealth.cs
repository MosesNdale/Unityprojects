using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Header("Custom Header")]

    [Range(50,200)]
    public int maxHealth = 100;
    public PlayerHealthSlider healthSlider;

    private int health;
    private bool isDead;

    private void Start()
    {
        health = maxHealth;
    }

    public void ResetHealth()
    {
        health = maxHealth;
    }

    public void Damage(int dmg) 
    {
        health -= dmg;

        if(health <= 0) 
        {
            isDead = true;
            health = 0;
        }

         healthSlider.SetTarget(health / (float)maxHealth);
    }

}
