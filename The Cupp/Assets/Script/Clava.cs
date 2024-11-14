using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clava : MonoBehaviour
{   

    [SerializeField]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI vitaText;
    Player player;

    bool hit = false;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player();
        player.punteggio = 0;
        player.vita = 3;
        scoreText.text = "Score: " + player.punteggio;
        vitaText.text = "Vite: " + player.vita;
    }
     
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {

        
        Debug.Log("ciao");
        if(!hit){

            hit = true;

            if(other.gameObject.CompareTag("Proiettile")){

                player.addPunteggio();
                scoreText.text = "Score:" + player.punteggio;
                Debug.Log("mammt");
            }

            if(other.gameObject.CompareTag("Bomba")){

                player.togliPunteggio();
                player.togliVita();
                scoreText.text = "Score:" + player.punteggio;
                vitaText.text = "Vite: " + player.vita;
            }
        }

        hit = false;
       
    }


}
