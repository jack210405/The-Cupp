using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void passa_scena_iniziale(){
        SceneManager.LoadScene("Prova1");
    }
    public void segreto(){
        SceneManager.LoadScene("Segreto");
    }
}
