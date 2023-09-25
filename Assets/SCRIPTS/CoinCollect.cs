using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class DesaparecerAlContacto : MonoBehaviour
{
    public PlayerMovement playermovement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            playermovement.AddScore();
        }
    }
}