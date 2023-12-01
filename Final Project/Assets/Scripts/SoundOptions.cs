using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundOptions : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    void Start()
    {
        if (PlayerPrefs.GetInt("Default Volume Changed") == 0)
        {
            masterSlider.value = 0.15f;
            sfxSlider.value = 0.15f;
            musicSlider.value = 0.15f;

            PlayerPrefs.SetInt("Default Volume Changed", 1);
        }
        else
        {
            masterSlider.value = PlayerPrefs.GetFloat("Master");
            sfxSlider.value = PlayerPrefs.GetFloat("SFX");
            musicSlider.value = PlayerPrefs.GetFloat("Music");

        }

    }

    public void SetVolume(string name, Slider slider)
    {
        PlayerPrefs.SetFloat(name, slider.value);

        float volume = Mathf.Log10(slider.value) * 20;
        if (slider.value == 0)
        {
            volume = -80;
        }
        mixer.SetFloat(name, volume);
    }

    public void SetMasterVolume()
    {
        SetVolume("Master", masterSlider);
    }

    public void SetSFXVolume()
    {
        SetVolume("SFX", sfxSlider);
    }

    public void SetMusicVolume()
    {
        SetVolume("Music", musicSlider);
    }
}
