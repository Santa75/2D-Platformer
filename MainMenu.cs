using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("lvl_1");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void StoryGame ()
    {
        SceneManager.LoadScene("Story Screen");
    }

    public void GoingBack ()
    {
        SceneManager.LoadScene("Menu Screen");
    }

    public void ControlsGame ()
    {
        SceneManager.LoadScene("Controls Screen");
    }

}
