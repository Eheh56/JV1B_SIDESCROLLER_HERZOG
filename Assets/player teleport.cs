using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerteleport : MonoBehaviour
{
    public GameObject currentteleporteur;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentteleporteur != null)
            {
                transform.position = currentteleporteur.GetComponent<teleporteur>().GetDestination().position;
            }
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("teleporteur"))
        {
            currentteleporteur = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("teleporteur"))
        {
            if (collision.gameObject == currentteleporteur)
            {
                currentteleporteur = null;
            }
        }
    }
}