using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void ExitButton()
    {
        Application.Quit();     //QuitGame
        Debug.Log("Game Closed");

    }

    public void StartGame()
    {
        SceneManager.LoadScene("BeforeGame");   //Move to BeforeGame Screen

    }
    public void BackToMain()
    {
        SceneManager.LoadScene("MainMenu");     //Move to Main Menu Screen

    }

}
