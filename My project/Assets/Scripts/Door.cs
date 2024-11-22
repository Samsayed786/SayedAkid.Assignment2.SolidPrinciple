using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]private Animator animator;
    private bool open = false;
    public void openDoor()
    {
      if (!open)
        {
            open = true;
            animator.SetTrigger("open");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
