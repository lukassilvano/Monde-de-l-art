using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");

            /*
            if (SceneManager.GetActiveScene().name == "Teste")
            {
                SceneManager.LoadScene("Teste");
            }
            else if (SceneManager.GetActiveScene().name == "Fase 2")
            {
                SceneManager.LoadScene("Fase 2");
            }
            else if (SceneManager.GetActiveScene().name == "Fase 3")
            {
                SceneManager.LoadScene("Fase 3");
            }
            */
        }
    }
}
