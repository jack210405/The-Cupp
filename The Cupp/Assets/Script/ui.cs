using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{

    public void passa_scena_iniziale(){
        SceneManager.LoadScene("Arena");
    }
    public void segreto(){
        SceneManager.LoadScene("Segreto");
    }

    public void tornamenu(){
        SceneManager.LoadScene("Menu_Iniziale");
    }

    public void esci(){
        Application.Quit();
    }
}
