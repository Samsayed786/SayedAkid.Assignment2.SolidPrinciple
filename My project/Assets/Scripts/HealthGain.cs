using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGain : Collectable 
{
    public int amount = 10;
    public override void Interact(PStats player)
    {
        Debug.Log("Health Gain");
        // call pplayer regenerating health 
        player.IncreaseHealth(amount);
        Destroy(gameObject);

    }

    

}
