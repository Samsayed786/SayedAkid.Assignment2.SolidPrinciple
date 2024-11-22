using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : Collectable
{
    public int amount = 10;
    public override void  Interact(PStats player)
    {
        Debug.Log("Health Decreased");
        //call player health take damage 
        player.DecreaseHealth(amount);
        Destroy(gameObject);

    }

   

}
