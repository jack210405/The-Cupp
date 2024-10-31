using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombe : Oggetti
{
    public float raggioEsplosione;

    public override void Muovi()
    {
        // Sovrascriviamo il metodo Muovi() per aggiungere un comportamento specifico alle bombe
        base.Muovi(); // Chiamiamo il metodo Muovi() della classe base per mantenere il movimento base
        // Aggiungi qui altri comportamenti specifici per le bombe, come la rotazione, l'accelerazione, ecc.
    }

    public void Esplodi()
    {
        // Logica dell'esplosione
        // ...
    }
}