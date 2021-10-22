using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Time = UnityEngine.Time;

public class DeathCanvas : MonoBehaviour
{
    public bool isDead;
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
            SceneManager.LoadScene("MainScene");
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isDead)
        {
            Application.Quit();
        }
    }
}
