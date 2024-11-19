using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGain : MonoBehaviour, IInteractable
{
    public void Interact(GameObject player)
    {
        Debug.Log("Health Gain");
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
