using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicIcon : MonoBehaviour
{
    public GameObject soundPanel;
    public Sprite spriteActive;
    public Sprite spriteInactive;
    //private SpriteRenderer sr;
    public bool isActive = false;

    void Start()
    {
        //sr = GetComponent<SpriteRenderer>();
        //sr.sprite = spriteActive;
    }

    public void changeState()
    {
        if (!isActive)
        {
            soundPanel.SetActive(true);
            isActive = true;
        }
        else
        {
            soundPanel.SetActive(false);
            isActive = false;
        }
    }

    public void SpriteSwitch(int value)
    {
        //if (value == 1)
        //{
        //    sr.sprite = spriteActive;
        //}
        //if (value == 2)
        //{
        //    sr.sprite = spriteInactive;
        //}
    }
}
