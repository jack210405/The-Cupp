using UnityEngine;

public class NemicoController : MonoBehaviour
{
    public GameObject proiettilePrefab;
    public Transform puntoDiSparo;
    public float forzaSparo = 20f;
    public float frequenzaDiSparo = 1f;
    public Transform giocatore;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= frequenzaDiSparo)
        {
            timer = 0f;
            Spara();
        }
        //giocatore = GameObject.Find("Player").transform;
    }

    void Spara()
    {
        GameObject proiettile = Instantiate(proiettilePrefab, puntoDiSparo.position, puntoDiSparo.rotation);
        Rigidbody rb = proiettile.GetComponent<Rigidbody>();

        Vector3 direzione = (giocatore.position - transform.position).normalized;
        rb.velocity = direzione * forzaSparo;

    }
}/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawni : MonoBehaviour
{

    [SerializeField]
    public GameObject proiettilePrefab;
    [SerializeField]
    public Transform firePoint;
    
    private InputActionReference shootAction;

    // Update is called once per frame
    void Update()
    {
        if(shootAction.action.WasPressedThisFrame()){
            FireProiettile();
        }
    }

    void FireProiettile(){
        GameObject newProiettile = Instantiate(proiettilePrefab, firePoint.position, firePoint.rotation);
    }
}
*/