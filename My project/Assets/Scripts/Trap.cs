using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour, IInteractable
{
    public void Interact(GameObject player)
    {
        Debug.Log("Health Decreased");
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Interact(other.gameObject);
        }
    }

}
