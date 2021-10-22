using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCanvas : MonoBehaviour
{
    public bool isDead = false;
    public GameObject panel;
    public void DeathHappens()
    {
        isDead = true;
    }

    void Update()
    {
        if (isDead)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isDead)
        {
            Debug.Log("retry");
            SceneManager.LoadScene("MainScene");
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isDead)
        {
            Debug.Log("quit");
            Application.Quit();
        }
    }
}
