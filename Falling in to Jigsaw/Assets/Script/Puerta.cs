using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
                animator.SetBool("ABRIR", true);
        }

    }

}
