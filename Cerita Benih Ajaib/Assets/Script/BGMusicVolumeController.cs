using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMusicVolumeController : MonoBehaviour
{
    public Slider bgmusic_slider;
    public AudioSource bgmusic_audiosource;

    void Start()
    {
        bgmusic_audiosource = GameObject.FindGameObjectWithTag("BGMusic").GetComponent<AudioSource>();
        bgmusic_slider.value = PlayerPrefs.GetFloat("bgmusic_slider_value", 0.5f);
        bgmusic_audiosource.volume = bgmusic_slider.value;
    }

    public void UpdateBGMusicVolume()
    {
        PlayerPrefs.SetFloat("bgmusic_slider_value", bgmusic_slider.value);
        bgmusic_audiosource.volume = bgmusic_slider.value;
    }
}
