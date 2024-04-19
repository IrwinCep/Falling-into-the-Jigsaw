using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLave : MonoBehaviour
{
    public GameObject Objetollave;
    public GameObject ColliderPuerta;


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            ColliderPuerta.gameObject.SetActive(true);
            Destroy(Objetollave);
        }

    }

}