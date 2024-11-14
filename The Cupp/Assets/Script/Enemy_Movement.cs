using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public List<GameObject> WayPoints;
    public float speed = 3;
    int index = 0;

    public Transform player; // Riferimento al giocatore



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 destination = WayPoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);
        if (distance <= 0.05) {
            
            if(index < WayPoints.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }

        }

        transform.LookAt(player.position);
        


    }
}
