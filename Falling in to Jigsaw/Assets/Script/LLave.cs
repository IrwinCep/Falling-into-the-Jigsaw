using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLave : MonoBehaviour
{
    public Collider ColliderPuerta;


    void OnTriggerEnter(Collider other)
    {
        print("Entrando en contactor con " + other);
        if (other.CompareTag("Player"))
        {
            print("Si es player");
            ColliderPuerta.enabled = true;
            Destroy(gameObject);
        }

    }

}