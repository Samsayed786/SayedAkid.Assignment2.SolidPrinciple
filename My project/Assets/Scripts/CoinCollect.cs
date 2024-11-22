using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : Collectable, IInteractable
{
    public int amount = 10;
    
    public override void Interact(PStats player)
    {
        Debug.Log("Coin ");
        // call the collectable being collected 
        player.IncreaseScore(amount);
      
        
    }

   }
