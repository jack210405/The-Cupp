using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandle : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI vitaText;
    Player player;
    
    bool touch = false;

    private void Start() {
        player = new Player();
    }

    public void OnCollisionEnter(Collision collision){

        if(touch == false){

            touch = true;

            if(collision.gameObject.CompareTag("Proiettile")){

                player.togliVita();
                vitaText.text = "Vite: " + player.vita;

            }
        }
        touch = false;
        
    }

    public void Update() {
        if(player.vita <= 0){
            SceneManager.LoadScene("Menu_Sconfitta");
            Debug.Log("hai perso");
        }
    }

    
    

   
    

}
