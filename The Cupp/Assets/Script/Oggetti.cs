using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oggetti : MonoBehaviour
{
    public float velocita;

    public virtual void Muovi()
    {
        // Implementazione di base per il movimento
        transform.Translate(Vector3.forward * velocita * Time.deltaTime);
    }
}
