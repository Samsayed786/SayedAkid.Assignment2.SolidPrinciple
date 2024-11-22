using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStats : MonoBehaviour
{
    public int health = 100;
    public int score = 0;
   
    void Start()
    {
      Debug.Log("Game Start. Health:" + health + " , Score: " + score);  
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }

    public void IncreaseHealth(int amount)
    {
        health += amount;
        Debug.Log("Health:" + health); 
    }

    public void DecreaseHealth(int amount)
    {
        health -= amount;
        Debug.Log("Health: " + health);
    }

   
    void Update()
    {
        
    }
}
