using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : MonoBehaviour, IInteractable
{
 public abstract void Interact(PStats player);
    void OnTriggerEnter(Collider other)
    {
        PStats player = other.GetComponent<PStats>();
        if (other.CompareTag("Player"))
        {
            Interact(player);
        }
        
    }

}
