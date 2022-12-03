using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
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
    //public Slider bgm_slider;
    //public AudioSource[] bgm_files;
    //void Start()
    //{
    //    bgm_slider.value = PlayerPrefs.GetFloat("bgm_value", 0.5f);
    //    for (int i = 0; i < bgm_files.Length; i++)
    //    {
    //        bgm_files[i].volume = bgm_slider.value;
    //    }
    //}

    //public void UpdateBGMVolume()
    //{
    //    PlayerPrefs.SetFloat("bgm_value", bgm_slider.value);
    //    for (int i = 0; i < bgm_files.Length; i++)
    //    {
    //        bgm_files[i].volume = bgm_slider.value;
    //    }
    //}

    [SerializeField] string BGMVolume = "BGMVolume";
    [SerializeField] string SFXVolume = "SFXVolume";
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider BGMSlider;
    [SerializeField] Slider SFXSlider;
    [SerializeField] float multiplier = 30f;

    private void Awake()
    {
        BGMSlider.onValueChanged.AddListener(BGMSliderValueChanged);
        SFXSlider.onValueChanged.AddListener(SFXSliderValueChanged);
    }

    private void Start()
    {
        BGMSlider.value = PlayerPrefs.GetFloat(BGMVolume, BGMSlider.value);
        SFXSlider.value = PlayerPrefs.GetFloat(SFXVolume, SFXSlider.value);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(BGMVolume, BGMSlider.value);
        PlayerPrefs.SetFloat(SFXVolume, SFXSlider.value);
    }

    private void BGMSliderValueChanged(float value)
    {
        mixer.SetFloat(BGMVolume, Mathf.Log10(value) * multiplier);
    }

    private void SFXSliderValueChanged(float value)
    {
        mixer.SetFloat(SFXVolume, Mathf.Log10(value) * multiplier);
    }
}
