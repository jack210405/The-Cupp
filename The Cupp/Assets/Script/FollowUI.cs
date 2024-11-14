using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUI : MonoBehaviour
{
    public Transform playerCamera;  // La camera del giocatore
    public float distanceFromPlayer = 1.0f;  // Distanza della barra della vita dalla camera

    void Update()
    {
        // Posiziona il canvas sempre davanti alla camera del giocatore
        Vector3 cameraForward = playerCamera.forward;
        Vector3 newPosition = playerCamera.position + cameraForward * distanceFromPlayer;
        newPosition.y-=0.05f;
        transform.position = newPosition;

        // Fa sì che il canvas segua la rotazione della camera
        transform.LookAt(playerCamera);
        transform.Rotate(0, 180, 0);  // Gira di 180 gradi per evitare che sia al contrario
    }
}
