using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class NemicoController : MonoBehaviour
{
    public GameObject enemy;
    public GameObject target;

    [SerializeField] private float timer = 5;
    private float bulletTime;

    public GameObject[] enemyBullets = new GameObject[5];
    public Transform spawnPoint;
    public float enemySpeed;
    Vector3 directionToTarget;
    void Update()
    {
        
        Spara();
    }

    void Spara()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = timer;
        int i = Random.Range(0,7+1);
        GameObject bulletobj = Instantiate(enemyBullets[i], spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletobj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);


    }
}