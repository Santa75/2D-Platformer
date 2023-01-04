using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public void lvl1()

    {
        SceneManager.LoadScene("lvl_1");
    }
    public void lvl2()

    {
        SceneManager.LoadScene("lvl_2");
    }
    public void EndThis()

    {
        SceneManager.LoadScene("Congrats Screen");
    }

}
