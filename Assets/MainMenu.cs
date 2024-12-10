using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update


    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("MovementTutorail");
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene("SettingsMenu 1");
    }

    

    public void QuitGame()
    {
        Application.Quit();
    }
}
