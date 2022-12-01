using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX_Volume_Controller : MonoBehaviour
{
    public Slider sfx_slider;
    public AudioSource[] sfx_files;
    void Start()
    {
        sfx_slider.value = PlayerPrefs.GetFloat("sfx_value", 0.5f);
        for (int i = 0 ; i < sfx_files.Length; i++)
        {
            sfx_files[i].volume = sfx_slider.value;
        }
    }

    public void UpdateSFXVolume()
    {
        PlayerPrefs.SetFloat("sfx_value", sfx_slider.value);
        for (int i = 0; i < sfx_files.Length; i++)
        {
            sfx_files[i].volume = sfx_slider.value;
        }
    }
}
