using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CompleteCheck : MonoBehaviour
{   
  public Animator animator;



  private void OnTriggerEnter2D(Collider2D collider)
  { 
      if (collider.gameObject.tag == "Player")
      {
          StartCoroutine(LoadingScreen());
      }
  }


  IEnumerator LoadingScreen()
  {
      animator.SetTrigger("GameCompleted");
      if(SceneManager.GetActiveScene().name == "Level1")
      {
        if(PlayerPrefs.GetInt("MaxLevel",1) <= 1)
        {
          PlayerPrefs.SetInt("MaxLevel",2);
        }
      }

      if(SceneManager.GetActiveScene().name == "Level2")
      {
        if(PlayerPrefs.GetInt("MaxLevel",1) <= 2)
        {
          PlayerPrefs.SetInt("MaxLevel",3);
        }
      }

      if(SceneManager.GetActiveScene().name == "Level3")
      {
        if(PlayerPrefs.GetInt("MaxLevel",1) <= 3)
        {
          PlayerPrefs.SetInt("MaxLevel",4);
        }
      }

      if(SceneManager.GetActiveScene().name == "Level4")
      {
        if(PlayerPrefs.GetInt("MaxLevel",1) <= 4)
        {
          PlayerPrefs.SetInt("MaxLevel",5);
        }
      }

      if(SceneManager.GetActiveScene().name == "Level5")
      {
        if(PlayerPrefs.GetInt("MaxLevel",1) <= 5)
        {
          PlayerPrefs.SetInt("MaxLevel",6);
        }
      }

      if(SceneManager.GetActiveScene().name == "Level6")
      {
        if(PlayerPrefs.GetInt("MaxLevel",1) <= 6)
        {
          PlayerPrefs.SetInt("MaxLevel",7);
        }
      }

      if(SceneManager.GetActiveScene().name == "Level7")
      {
        if(PlayerPrefs.GetInt("MaxLevel",1) <= 7)
        {
          PlayerPrefs.SetInt("MaxLevel",8);
        }
      }

      if(SceneManager.GetActiveScene().name == "Level8")
      {
        if(PlayerPrefs.GetInt("MaxLevel",1) <= 8)
        {
          PlayerPrefs.SetInt("MaxLevel",9);
        }
      }

      if(SceneManager.GetActiveScene().name == "Level9")
      {
        if(PlayerPrefs.GetInt("MaxLevel",1) <= 9)
        {
          PlayerPrefs.SetInt("MaxLevel",10);
        }
      }

      yield return new WaitForSeconds(0.7f);
        PlayerPrefs.SetInt("lastScene",SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("LevelComplete");

  }
}
