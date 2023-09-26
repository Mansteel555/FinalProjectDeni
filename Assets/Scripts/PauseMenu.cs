using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;


    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
