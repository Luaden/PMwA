using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene(1);

    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
