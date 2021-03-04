using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject LevelView;
    public GameObject playButton;


    private GameObject[] buttonList;

   private void Start()
   {
         //PlayerPrefs.SetInt("MaxLevel",1);

   }
    public void StartGame()
   {

       LevelView.SetActive(true);
       playButton.SetActive(false);

              buttonList = GameObject.FindGameObjectsWithTag("LevelButton");
       int maxLevel = PlayerPrefs.GetInt("MaxLevel",1);
       Debug.Log(buttonList.Length);
       for (int i = 0; i < buttonList.Length; i++)
       {
        Button currentButton  = buttonList[i].GetComponent<Button>(); 
          if (maxLevel < i + 1)
          {     
              currentButton.interactable = false;
          }
       }

   }













   public void StartLevel1()
   {
     SceneManager.LoadScene("Level1");
   }

    public void StartLevel2()
   {
        SceneManager.LoadScene("Level2");
    
   }


   public void StartLevel3()
   {
       SceneManager.LoadScene("Level3");
   }


   public void StartLevel4()
   {
        SceneManager.LoadScene("Level4");
      
   }


   public void StartLevel5()
   {
      SceneManager.LoadScene("Level5");
    
   }


   public void StartLevel6()
   {
        SceneManager.LoadScene("Level6");
     
   }


   public void StartLevel7()
   {
         SceneManager.LoadScene("Level7");
      
   }


   public void StartLevel8()
   {
         SceneManager.LoadScene("Level8");
       
   }


   public void StartLevel9()
   {
      SceneManager.LoadScene("Level9"); 
   }


   public void StartLevel10()
   {
       SceneManager.LoadScene("Level10"); 
      
   }

}
