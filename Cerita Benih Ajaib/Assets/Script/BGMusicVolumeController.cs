using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMusicVolumeController : MonoBehaviour
{
    //public Slider bgmusic_slider;
    //public AudioSource bgmusic_audiosource;

    //void Start()
    //{
    //    bgmusic_audiosource = GameObject.FindGameObjectWithTag("BGMusic").GetComponent<AudioSource>();
    //    bgmusic_slider.value = PlayerPrefs.GetFloat("bgmusic_slider_value", 0.5f);
    //    bgmusic_audiosource.volume = bgmusic_slider.value;
    //}

    //public void UpdateBGMusicVolume()
    //{
    //    PlayerPrefs.SetFloat("bgmusic_slider_value", bgmusic_slider.value);
    //    bgmusic_audiosource.volume = bgmusic_slider.value;
    //}
    public Slider bgm_slider;
    public AudioSource[] bgm_files;
    void Start()
    {
        bgm_slider.value = PlayerPrefs.GetFloat("bgm_value", 0.5f);
        for (int i = 0; i < bgm_files.Length; i++)
        {
            bgm_files[i].volume = bgm_slider.value;
        }
    }

    public void UpdateBGMVolume()
    {
        PlayerPrefs.SetFloat("bgm_value", bgm_slider.value);
        for (int i = 0; i < bgm_files.Length; i++)
        {
            bgm_files[i].volume = bgm_slider.value;
        }
    }
}
