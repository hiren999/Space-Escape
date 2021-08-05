using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public int maxHealth = 250;
    public int currentHealth;
    public AudioSource source;

   

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        source = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
       
        

        if (currentHealth == 0)
        {
            source.Play();
            Destroy(this.gameObject, 3);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);


    }
}

    




