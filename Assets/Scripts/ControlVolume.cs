using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVolume : MonoBehaviour
{
    public Slider slider;
    public float musicVolume;

    public void SetVolume()
    {
        float sliderValue = slider.value;

        musicVolume = sliderValue;
        AkSoundEngine.SetRTPCValue("MusicVolume", musicVolume);
    }
}
