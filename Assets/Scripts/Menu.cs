using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nextScene;

    public void MenuStart()
    {
        SceneManager.LoadScene(nextScene);
        Debug.Log("start");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
