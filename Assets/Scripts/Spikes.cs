using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Spikes : MonoBehaviour
{

    private void  OnTriggerEnter2D(Collider2D collider)
    {           
        
         Debug.Log("Hey");

        if (collider.gameObject.tag == "Player")
        {   
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
