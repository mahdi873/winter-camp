using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunnerHealth : MonoBehaviour
{
    
    public int maxHealth = 10;

    
    private int currentHealth;

    
    public Text healthText;

    
    public int object1HealthAmount = 10;
    public int object2HealthAmount = 0;

    
    void Start()
    {
        
        currentHealth = maxHealth;
    }

    
    void Update()
    {
        
        healthText.text = "Health: " + currentHealth;

        
        if (currentHealth == 0)
        {
            SceneManager.LoadScene(GameOver);
        }
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name == "Sucre")
        {
         
            currentHealth = Mathf.Min(currentHealth + object1HealthAmount, maxHealth);
        }
        else if (collision.gameObject.name == "Farine")
        {
         
            currentHealth = Mathf.Max(currentHealth + object2HealthAmount, 0);
        }
    }
}
