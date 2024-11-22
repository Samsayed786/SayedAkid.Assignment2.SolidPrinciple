using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch : Collectable
{
    [SerializeField] private Door door;
    public override void Interact(PStats player)
    {
        Debug.Log("Switch Activated ");
        // call the collectable being collected 
        door.openDoor();
     


    }
}
