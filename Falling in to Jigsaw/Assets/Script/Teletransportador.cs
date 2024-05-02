using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public GameObject areaActual;
    public GameObject areaDestino;

    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(
            this.transform.position,
            "T_1_cursor_al");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        GameObject player = other.gameObject;
        player.SetActive(false);
        areaActual.SetActive(false);

        GameObject nuevaArea = Instantiate(areaDestino);

        PuntoSpawn punto =
            GameObject.FindFirstObjectByType<PuntoSpawn>();

        player.transform.position = punto.transform.position;
        player.SetActive(true);
    }
}
