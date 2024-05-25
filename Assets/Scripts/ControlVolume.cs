using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVolume : MonoBehaviour
{
    public Slider slider;
    public FloatValue musicVolume;

    public void SetVolume()
    {
        float sliderValue = slider.value;

        musicVolume.runtimeValue = sliderValue;
        AkSoundEngine.SetRTPCValue("MusicVolume", musicVolume.runtimeValue);
    }
}
