using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{    
    public GameObject button;
    void Start()
    {
        if (PlayerPrefs.GetInt("lastScene",0) == 10)
        {
            button.SetActive(false);
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastScene",0));
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastScene",0)+ 1);

    }
}
