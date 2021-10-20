using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{
    public AudioSource music;
    public Slider slider;
    public GameObject musicIcon;

    public void volumeChange()
    {
        music.volume = slider.value;
    }

    void Update()
    {
        if (slider.value == 0)
        {
            musicIcon.SendMessage("SpriteSwitch" , 1);
        }
        else
        {
            musicIcon.SendMessage("SpriteSwitch", 2);
        }
    }
}