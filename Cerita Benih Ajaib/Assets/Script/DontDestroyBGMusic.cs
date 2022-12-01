using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyBGMusic : MonoBehaviour
{
    //public static DontDestroyBGMusic instance = null;

    //private void Awake()
    //{
    //    if (instance == null) { instance = this; }
    //    else if (instance != null)
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    DontDestroyOnLoad(this.gameObject);
    //}
    public AudioSource[] bgm_files;
    void Start()
    {
        SameBGMSettings();
    }

    private void SameBGMSettings()
    {
        float bgm_slider_value = PlayerPrefs.GetFloat("bgm_value", 0.5f);
        for (int i = 0; i < bgm_files.Length; i++)
        {
            bgm_files[i].volume = bgm_slider_value;
        }
    }
}
