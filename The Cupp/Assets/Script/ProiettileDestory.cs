using UnityEngine;

public class Proiettile : MonoBehaviour
{
    // Questo metodo viene chiamato quando il proiettile collide con un altro oggetto
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se il proiettile ha colpito il cubo
        if (collision.gameObject.CompareTag("Limite") || collision.gameObject.CompareTag("Clava"))  // Assicurati che il cubo abbia il tag "Cubo"
        {
            // Distrugge il proiettile
            Destroy(gameObject);
        }
    }
}

