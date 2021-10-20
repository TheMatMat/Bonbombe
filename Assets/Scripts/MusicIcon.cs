using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicIcon : MonoBehaviour
{
    public GameObject soundPanel;
    public Sprite spriteActive;
    public Sprite spriteInactive;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void Appear()
    {
        soundPanel.SetActive(true);
    }

    public void Disappear()
    {
        soundPanel.SetActive(false);
    }

    public void SpriteSwitch(int value)
    {
        if (value == 1)
        {

        }
    }
}
